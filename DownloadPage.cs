using System.Diagnostics;
using System.Text.RegularExpressions;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace WinFormsApp1
{
    public partial class DownloadPage : UserControl
    {
        private readonly HttpClient _httpClient;
        private readonly int _userId;
        private readonly YoutubeClient _youtubeClient;

        private CancellationTokenSource cts;

        private string UrlDownload;
        private string LocalPath;
        private string FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        private string FileName = "";
        private string YoutubeString;


        public DownloadPage(HttpClient httpClient, int userId, YoutubeClient youtubeClient)
        {
            _youtubeClient = youtubeClient;
            _httpClient = httpClient;
            _userId = userId;

            InitializeComponent();


            cbbConnectNum.Items.AddRange(new object[] { 1, 2, 4, 8, 16, 24, 32 });
            cbbConnectNum.SelectedIndex = 2;

            radioButtonNone.Checked = true;

            Disposed += OnDispose;
        }

        private void OnDispose(object sender, EventArgs e)
        {
            if (cts != null)
            {
                if (!cts.IsCancellationRequested)
                {
                    cts.Cancel();
                }
                cts.Dispose();
            }
        }

        private void UpdateLocalPath()
        {
            txtLocalpath.Text = LocalPath = Path.Combine(FolderPath, FileName);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                FolderPath = folderDlg.SelectedPath;
                UpdateLocalPath();
            }
        }

        private void BeginDownload()
        {
            if (radioButtonNone.Checked)
            {
                UrlDownload = txtUrlDownload.Text;
            }

            groupBox1.Enabled = false;
            btnDownload.Enabled = false;
            btnCancel.Enabled = true;

            labelStatus.BackColor = labelFileSize.BackColor = Color.Cyan;
            labelStatus.Text = "Status : Downloading";
            labelFileSize.Text = "File size : ...";

            Cursor = Cursors.WaitCursor;
        }

        private void UpdateFileSize(long fileSize)
        {
            Invoke(() =>
            {
                labelFileSize.Text = $"File size : {fileSize.ToString("N0")} Bytes";
            });
        }

        private bool CheckFileExist()
        {
            if (File.Exists(LocalPath))
            {
                DialogResult result = MessageBox.Show("The file already exists. Do you want to add an index to it?", "Confirm"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string extensionFile = Path.GetExtension(FileName);
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(FileName);

                    int count = 1;
                    FileName = $"{fileNameWithoutExtension}({count}){extensionFile}";

                    while (File.Exists(Path.Combine(FolderPath, FileName)))
                    {
                        count++;
                        FileName = $"{fileNameWithoutExtension}({count}){extensionFile}";
                    }

                    UpdateLocalPath();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    File.Create(LocalPath).Dispose();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Url download or local path is invalid");
                    return false;
                }
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (txtLocalpath.Text.Length == 0 || txtUrlDownload.Text.Length == 0)
            {
                MessageBox.Show("Field is missed");
                return;
            }

            if (!CheckFileExist())
            {
                radioButtonNone.Checked = true;
                return;
            }

            BeginDownload();

            MyDownloadBooster d = new MyDownloadBooster()
            {
                UrlFileDownload = UrlDownload,
                LocalPath = txtLocalpath.Text,
                ConnectionNumber = Convert.ToInt32(cbbConnectNum.SelectedItem),
                DateTime = DateTime.Now,
                UserId = _userId,
            };
            d.FileSizeUpdated += UpdateFileSize;

            cts = new CancellationTokenSource();

            await Task.Run(async () =>
            {
                d.Status = await d.DownloadAsync(_httpClient, cts.Token);
                if (radioButtonYTBmp3.Checked == true || radioButtonYTBmp4.Checked == true)
                {
                    d.UrlFileDownload = YoutubeString;
                }
                d.Add();
            });

            EndDownload(d);
        }

        private void EndDownload(MyDownloadBooster d)
        {
            labelStatus.BackColor = labelFileSize.BackColor = Color.GreenYellow;
            labelStatus.Text = "Status : " + (d.Status ? "Done" : "Fail");
            labelFileSize.Text = $"File size : {d.FileSize.ToString("N0")} Bytes";

            groupBox1.Enabled = true;
            radioButtonNone.Checked = true;
            btnDownload.Enabled = true;
            btnCancel.Enabled = false;

            Cursor = Cursors.Default;

            if (d.Status == true)
            {
                DialogResult result = MessageBox.Show($"Downloaded successfully at: {d.LocalPath}, open it", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Process process = new Process();
                    process.StartInfo.FileName = d.LocalPath;
                    process.StartInfo.UseShellExecute = true;
                    process.Start();
                }
            }
            else
            {
                MessageBox.Show("Download was cancelled or failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void txtUrlDownload_TextChanged(object sender, EventArgs e)
        {
            if (txtUrlDownload.Text.Length == 0)
            {
                txtLocalpath.Text = string.Empty;
                return;
            }

            FileName = Path.GetFileName(txtUrlDownload.Text);
            UpdateLocalPath();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
            cts?.Dispose();
        }

        private async void radioButtonYTB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYTBmp3.Checked == true || radioButtonYTBmp4.Checked == true)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    string urlVideo = txtUrlDownload.Text;
                    string nameVideo;
                    YoutubeExplode.Videos.Video video = await _youtubeClient.Videos.GetAsync(urlVideo);

                    nameVideo = Regex.Replace(video.Title, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);
                    nameVideo = nameVideo.Substring(0, Math.Min(nameVideo.Length, 20));
                    StreamManifest streamManifest = await _youtubeClient.Videos.Streams.GetManifestAsync(urlVideo);

                    YoutubeExplode.Videos.Streams.IStreamInfo streamInfo = null;
                    if (radioButtonYTBmp3.Checked == true)
                    {
                        streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                    }
                    else if (radioButtonYTBmp4.Checked == true)
                    {
                        streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                    }

                    UrlDownload = streamInfo.Url;
                    FileName = $"{nameVideo}.{streamInfo.Container}";
                    UpdateLocalPath();

                    Cursor = Cursors.Default;
                    YoutubeString = video.Url;
                }
                catch
                {
                    MessageBox.Show("Error");
                    radioButtonNone.Checked = true;
                    Cursor = Cursors.Default;
                }
            }
            else if (radioButtonNone.Checked == true)
            {
                txtUrlDownload_TextChanged(sender, e);
            }
        }
    }
}
