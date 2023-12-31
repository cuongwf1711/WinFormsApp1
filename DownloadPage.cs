using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class DownloadPage : UserControl
    {
        private readonly HttpClient _httpClient;
        private readonly int _userId;
        private CancellationTokenSource cts;

        private string UrlDownload;
        private string LocalPath;
        private string FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        private string FileName;

        private BindingList<InfoDownloading> dataDownloading = new BindingList<InfoDownloading>();

        public DownloadPage(HttpClient httpClient, int userId)
        {
            _httpClient = httpClient;
            _userId = userId;

            InitializeComponent();

            dataGridView1.DataSource = dataDownloading;
            cbbConnectNum.Items.AddRange(new object[] { 1, 2, 4, 8, 16, 24 });
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
            if(radioButtonNone.Checked)
            {
                UrlDownload = txtUrlDownload.Text;
            }

            groupBox1.Enabled = false;
            btnDownload.Enabled = false;
            btnCancel.Enabled = true;


            labelStatus.Text = "Status : Downloading";
            labelFileSize.Text = "File size : ...";
            labelPercentage.Text = "0 %";
            progressBar1.Value = 0;

            dataDownloading.Clear();
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
            cts = new CancellationTokenSource();

            if (txtLocalpath.Text.Length == 0 || txtUrlDownload.Text.Length == 0)
            {
                MessageBox.Show("Field is missed");
                return;
            }

            if(!CheckFileExist())
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

            Progress<InfoDownloading> progress = new Progress<InfoDownloading>(updateDownloading);
            await Task.Run(async () =>
            {
                d.Status = await d.DownloadAsync(progress, _httpClient, cts.Token);
                d.Add();
            });

            EndDownload(d);
        }

        private void EndDownload(MyDownloadBooster d)
        {
            labelStatus.Text = $"Status : {d.Status}";
            labelFileSize.Text = $"File size : {d.FileSize.ToString("N0")} Bytes";

            groupBox1.Enabled = true;
            radioButtonNone.Checked = true;
            btnDownload.Enabled = true;
            btnCancel.Enabled = false;

            if (d.Status == true)
            {
                DialogResult result = MessageBox.Show($"Downloaded successfully at: {d.LocalPath}, open it", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Process process = new System.Diagnostics.Process()
                    {
                        StartInfo = new ProcessStartInfo() { UseShellExecute = true, FileName = d.LocalPath }
                    };
                    process.Start();
                }
            }
            else
            {
                MessageBox.Show("Download was cancelled or failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void updateDownloading(InfoDownloading infoDownloading)
        {
            InfoDownloading obj = dataDownloading.FirstOrDefault(p => p.FileName == infoDownloading.FileName);
            if (infoDownloading.FileName == LocalPath)
            {
                labelPercentage.Text = infoDownloading.TotalBytesDownloaded.ToString();

                if(infoDownloading.FileSize > 0) 
                {
                    int percent = (int)Math.Round((double)infoDownloading.TotalBytesDownloaded * 100 / infoDownloading.FileSize);
                    progressBar1.Value = percent;
                    labelPercentage.Text = $"{percent} %";
                }

                if (dataDownloading.Count == 0)
                {
                    dataDownloading.Add(infoDownloading);
                }
                else
                {
                    obj.BytesSegmentDownloaded = infoDownloading.BytesSegmentDownloaded;
                    obj.Status = infoDownloading.Status;
                    dataDownloading.ResetBindings();
                }
            }
            else
            {
                int percent = (int)(infoDownloading.TotalBytesDownloaded * 100 / infoDownloading.FileSize);
                progressBar1.Value = percent;
                labelPercentage.Text = $"{percent} %";

                if (obj != null)
                {
                    obj.BytesSegmentDownloaded = infoDownloading.BytesSegmentDownloaded;
                    obj.Status = infoDownloading.Status;
                    dataDownloading.ResetBindings();
                }
                else
                {
                    dataDownloading.Add(infoDownloading);
                }
            }
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            if (txtUrlDownload.Text.Length == 0)
            {
                txtLocalpath.Text = string.Empty;
                return;
            }
            FileName = Path.GetFileName(txtUrlDownload.Text);
            UrlDownload = txtUrlDownload.Text;
            UpdateLocalPath();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
            cts?.Dispose();
        }

        private async void radioButtonYTB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYTBmp3.Checked == true)
            {
                Cursor = Cursors.WaitCursor;
                YtbParse ytbParse = new YtbParse() { UrlOfVideo = txtUrlDownload.Text };
                string nameVideo = await ytbParse.GetName();
                if (nameVideo.IsNullOrEmpty())
                {
                    MessageBox.Show("Error");
                    radioButtonNone.Checked = true;
                    Cursor = Cursors.Default;
                    return;
                }
                UrlDownload = await ytbParse.GetUrlDownloadMp3();
                FileName = nameVideo + ".mp3";
                UpdateLocalPath();
                Cursor = Cursors.Default;
            }
            else if (radioButtonYTBmp4.Checked == true)
            {
                Cursor = Cursors.WaitCursor;
                YtbParse ytbParse = new YtbParse() { UrlOfVideo = txtUrlDownload.Text };
                string nameVideo = await ytbParse.GetName();
                if (nameVideo.IsNullOrEmpty())
                {
                    MessageBox.Show("Error");
                    radioButtonNone.Checked = true;
                    Cursor = Cursors.Default;
                    return;
                }
                UrlDownload = await ytbParse.GetUrlDownloadMp4();
                FileName = nameVideo + ".mp4";
                UpdateLocalPath();
                Cursor = Cursors.Default;
            }
            else if (radioButtonNone.Checked == true)
            {
                txtURL_TextChanged(sender, e);
            }
        }
    }
}
