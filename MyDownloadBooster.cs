using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace WinFormsApp1
{
    public class MyDownloadBooster
    {
        public event Action<long> FileSizeUpdated;

        public int MyDownloadBoosterId { get; set; }
        [Required]
        public string UrlFileDownload { get; set; }
        [Required]
        public string LocalPath { get; set; }
        public int ConnectionNumber { get; set; }
        public DateTime DateTime { get; set; }
        public bool Status { get; set; }
        public long FileSize { get; private set; }
        public int UserId { get; set; }

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

        private async Task<bool> DownloadSingle(HttpClient httpClient, CancellationToken token)
        {
            using (Stream stream = await httpClient.GetStreamAsync(UrlFileDownload, token))
            {
                using (FileStream outputFileStream = new FileStream(LocalPath, FileMode.Create))
                {
                    await stream.CopyToAsync(outputFileStream, token);
                }
            }
            return true;
        }


        public async Task<bool> DownloadAsync(HttpClient httpClient, CancellationToken token)
        {
            ConcurrentDictionary<long, string> tempFilesDictionary = new ConcurrentDictionary<long, string>();
            try
            {
                using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Head, new Uri(UrlFileDownload));
                using HttpResponseMessage responseHeader = await httpClient.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseHeadersRead, token);

                FileSize = responseHeader.Content.Headers.ContentLength.GetValueOrDefault();
                if (FileSize > 0)
                {
                    FileSizeUpdated?.Invoke(FileSize);
                }
                if (FileSize < ConnectionNumber)
                {
                    ConnectionNumber = 1;
                }

                if (!responseHeader.Headers.AcceptRanges.Contains("bytes") || ConnectionNumber == 1)
                {
                    return await DownloadSingle(httpClient, token);
                }
                
                await Parallel.ForEachAsync(GetSegmentsAsync(token), new ParallelOptions() { CancellationToken = token }, async (segment, token) =>
                {
                    using HttpRequestMessage requestMessage = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri(UrlFileDownload),
                        Headers = { Range = new RangeHeaderValue(segment.Start, segment.End) }
                    };

                    using HttpResponseMessage responseMessage = await httpClient.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead, token);

                    string tempFilePath = Path.GetTempFileName();
                    tempFilesDictionary.TryAdd(segment.Start, tempFilePath);

                    using (Stream stream = await responseMessage.Content.ReadAsStreamAsync(token))
                    {
                        using (FileStream outputFileStream = new FileStream(tempFilePath, FileMode.Create))
                        {
                            await stream.CopyToAsync(outputFileStream, token);
                        }
                    }
                });


                foreach (var tempFile in tempFilesDictionary.OrderBy(b => b.Key))
                {
                    using (FileStream tempFileStream = new FileStream(tempFile.Value, FileMode.Open))
                    {
                        using (FileStream destinationStream = new FileStream(LocalPath, FileMode.Append))
                        {
                            await tempFileStream.CopyToAsync(destinationStream, token);
                        }
                    }
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