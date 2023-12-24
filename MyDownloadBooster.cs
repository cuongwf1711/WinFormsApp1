using Azure.Core;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace WinFormsApp1
{
    public class MyDownloadBooster
    {
        public event Action<long> FileSizeUpdated;

        public int MyDownloadBoosterId { get; set; }
        public string UrlFileDownload { get; set; }
        public string LocalPath { get; set; }
        public int ConnectionNumber { get; set; }
        public DateTime DateTime { get; set; }
        public bool Status { get; set; }
        public long FileSize { get; private set; }
        public int UserId { get; set; }
        public User User { get; set; }

        private const int bufferSize = 1024 * 128;
        private const long updateThreshold = 2 * 1024 * 1024;

        public bool Add()
        {
            try
            {
                using (MyContext Db = new MyContext())
                {
                    Db.MyDownloadBoosters.Add(this);
                    Db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public MyDownloadBooster Get()
        {
            using (MyContext Db = new MyContext())
            {
                return Db.MyDownloadBoosters.FirstOrDefault(p => p.MyDownloadBoosterId == MyDownloadBoosterId);
            }
        }

        public bool Delete()
        {
            try
            {
                using (MyContext Db = new MyContext())
                {
                    Db.MyDownloadBoosters.Remove(this);
                    Db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async IAsyncEnumerable<Range> GetSegmentsAsync(CancellationToken token)
        {
            for (int chunk = 0; chunk < ConnectionNumber; chunk++)
            {
                token.ThrowIfCancellationRequested();
                yield return new Range()
                {
                    Start = chunk * (FileSize / ConnectionNumber),
                    End = chunk == ConnectionNumber - 1 ? FileSize - 1 : (chunk + 1) * (FileSize / ConnectionNumber) - 1
                };
            }
        }

        private async Task<bool> DownloadSingle(IProgress<InfoDownloading> progress, HttpClient httpClient, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            if (FileSize > 0)
            {
                FileSizeUpdated?.Invoke(FileSize);
            }

            using (HttpResponseMessage response = await httpClient.GetAsync(UrlFileDownload, HttpCompletionOption.ResponseHeadersRead, token))
            {
                using (Stream stream = await response.Content.ReadAsStreamAsync(token))
                {
                    using (FileStream outputFileStream = new FileStream(LocalPath, FileMode.Create))
                    {
                        long bytesDownloadedSinceLastUpdate = 0;
                        byte[] buffer = new byte[bufferSize];
                        int bytesRead;

                        InfoDownloading infoDownloading = new InfoDownloading()
                        {
                            FileName = LocalPath,
                            FileSize = FileSize,
                        };

                        while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, token)) > 0)
                        {
                            token.ThrowIfCancellationRequested();

                            infoDownloading.TotalBytesDownloaded += bytesRead;
                            infoDownloading._bytesSegmentDownloaded += bytesRead;
                            infoDownloading.TotalBytesSegment += bytesRead;

                            bytesDownloadedSinceLastUpdate += bytesRead;
                            if (bytesDownloadedSinceLastUpdate >= updateThreshold)
                            {
                                infoDownloading.Status = "Downloading";
                                progress.Report(infoDownloading);
                                bytesDownloadedSinceLastUpdate = 0;
                            }

                            await outputFileStream.WriteAsync(buffer, 0, bytesRead, token);
                        }

                        FileSize = infoDownloading.TotalBytesDownloaded;

                        infoDownloading.Status = "Done";
                        progress.Report(infoDownloading);
                    }
                }
            }
            return true;
        }

        public async Task<bool> DownloadAsync(IProgress<InfoDownloading> progress, HttpClient httpClient, CancellationToken token)
        {
            ConcurrentDictionary<long, string> tempFilesDictionary = new ConcurrentDictionary<long, string>();
            try
            {
                token.ThrowIfCancellationRequested();

                using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Head, new Uri(UrlFileDownload));
                using HttpResponseMessage responseHeader = await httpClient.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseHeadersRead, token);
                FileSize = responseHeader.Content.Headers.ContentLength.GetValueOrDefault();
                
                if (!responseHeader.Headers.AcceptRanges.Contains("bytes") || ConnectionNumber == 1)
                {
                    return await DownloadSingle(progress, httpClient, token);
                }

                if(FileSize <= 0)
                { 
                    return false; 
                }
                FileSizeUpdated?.Invoke(FileSize);

                long totalBytesRead = 0;
                await Parallel.ForEachAsync(GetSegmentsAsync(token), new ParallelOptions() { CancellationToken = token }, async (segment, token) =>
                {
                    token.ThrowIfCancellationRequested();
                    using HttpRequestMessage requestMessage = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri(UrlFileDownload),
                        Headers = { Range = new RangeHeaderValue(segment.Start, segment.End) }
                    };

                    using HttpResponseMessage responseMessage = await httpClient.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead, token);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        token.ThrowIfCancellationRequested();
                        string tempFilePath = Path.GetTempFileName();
                        using (Stream stream = await responseMessage.Content.ReadAsStreamAsync(token))
                        {
                            using (FileStream outputFileStream = new FileStream(tempFilePath, FileMode.Create))
                            {
                                long bytesDownloadedSinceLastUpdate = 0;
                                byte[] buffer = new byte[bufferSize];
                                int bytesRead;

                                InfoDownloading infoDownloading = new InfoDownloading()
                                {
                                    FileName = Path.GetFileName(tempFilePath),
                                    FileSize = FileSize,
                                    TotalBytesSegment = segment.End - segment.Start + 1,
                                };

                                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, token)) > 0)
                                {
                                    token.ThrowIfCancellationRequested();

                                    Interlocked.Add(ref totalBytesRead, bytesRead);
                                    infoDownloading.TotalBytesDownloaded = totalBytesRead;
                                    Interlocked.Add(ref infoDownloading._bytesSegmentDownloaded, bytesRead);

                                    bytesDownloadedSinceLastUpdate += bytesRead;
                                    if (bytesDownloadedSinceLastUpdate >= updateThreshold)
                                    {
                                        infoDownloading.Status = "Downloading";
                                        progress.Report(infoDownloading);
                                        bytesDownloadedSinceLastUpdate = 0;
                                    }
                                    await outputFileStream.WriteAsync(buffer, 0, bytesRead, token);
                                }

                                infoDownloading.Status = "Done";
                                progress.Report(infoDownloading);
                            }
                        }
                        tempFilesDictionary.TryAdd(segment.Start, tempFilePath);
                    }
                    else
                    {
                        throw new Exception();
                    }
                });
                
                foreach (var tempFile in tempFilesDictionary.OrderBy(b => b.Key))
                {
                    token.ThrowIfCancellationRequested();
                    using (FileStream tempFileStream = new FileStream(tempFile.Value, FileMode.Open))
                    {
                        using (FileStream destinationStream = new FileStream(LocalPath, FileMode.Append))
                        {
                            byte[] buffer = new byte[bufferSize];
                            int bytesRead;
                            while ((bytesRead = await tempFileStream.ReadAsync(buffer, 0, buffer.Length, token)) > 0)
                            {
                                await destinationStream.WriteAsync(buffer, 0, bytesRead, token);
                            }
                        }
                    }
                    File.Delete(tempFile.Value);
                }


                return true;
            }
            catch (Exception ex) 
            {
                Debug.WriteLine(ex);

                if (File.Exists(LocalPath))
                {
                    File.Delete(LocalPath);
                }
                return false;
            }
            finally
            {
                foreach (var tempFile in tempFilesDictionary)
                {
                    File.Delete(tempFile.Value);
                }
                tempFilesDictionary.Clear();
            }

        }
    }
}