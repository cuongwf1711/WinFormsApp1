using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class DownloadPage : UserControl
    {
        private readonly HttpClient _httpClient;
        private readonly int _userId;
        public CancellationTokenSource cts { get; set; }

        private string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        private string fileName = "";
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
        }

        void UpdateLocalPath()
        {
            txtLocalpath.Text = Path.Combine(defaultPath, fileName);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                defaultPath = folderDlg.SelectedPath;
                UpdateLocalPath();
            }
        }

        private void BeginDownload()
        {
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

        private string pathSaveDownloading;

        private void CheckFileExist()
        {
            if (File.Exists(txtLocalpath.Text))
            {
                DialogResult result = MessageBox.Show("The file already exists. Do you want to add an index to it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string extension = Path.GetExtension(fileName);
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

                    int count = 1;
                    fileName = $"{fileNameWithoutExtension}({count}){extension}";

                    while (File.Exists(Path.Combine(defaultPath, fileName)))
                    {
                        count++;
                        fileName = $"{fileNameWithoutExtension}({count}){extension}";
                    }

                    UpdateLocalPath();
                }
            }

            try
            {
                File.Create(txtLocalpath.Text).Dispose();
            }
            catch
            {
                throw;
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (txtLocalpath.Text == string.Empty || txtURL.Text == string.Empty)
            {
                MessageBox.Show("Field is missed");
                return;
            }

            try
            {
                CheckFileExist();
            }
            catch
            {
                MessageBox.Show("Url download or local path is invalid");
                radioButtonNone.Enabled = true;
                return;
            }

            BeginDownload();

            pathSaveDownloading = txtLocalpath.Text;

            MyDownloadBooster d = new MyDownloadBooster()
            {
                UrlFileDownload = txtURL.Text,
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
            });
            d.Add();

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
            if (infoDownloading.FileName == pathSaveDownloading)
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
            if (txtURL.Text.Length == 0)
            {
                txtLocalpath.Text = string.Empty;
                return;
            }
            fileName = Path.GetFileName(txtURL.Text);
            UpdateLocalPath();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        private async void radioButtonYTB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYTBmp3.Checked == true)
            {
                Cursor = Cursors.WaitCursor;
                YtbParse ytbParse = new YtbParse() { UrlOfVideo = txtURL.Text };
                string nameVideo = await ytbParse.GetName();
                if (nameVideo.IsNullOrEmpty())
                {
                    MessageBox.Show("Error");
                    radioButtonNone.Checked = true;
                    Cursor = Cursors.Default;
                    return;
                }
                txtURL.Text = await ytbParse.GetUrlDownloadMp3();
                fileName = nameVideo + ".mp3";
                UpdateLocalPath();
                Cursor = Cursors.Default;
            }
            else if (radioButtonYTBmp4.Checked == true)
            {
                Cursor = Cursors.WaitCursor;
                YtbParse ytbParse = new YtbParse() { UrlOfVideo = txtURL.Text };
                string nameVideo = await ytbParse.GetName();
                if (nameVideo.IsNullOrEmpty())
                {
                    MessageBox.Show("Error");
                    radioButtonNone.Checked = true;
                    Cursor = Cursors.Default;
                    return;
                }
                txtURL.Text = await ytbParse.GetUrlDownloadMp4();
                fileName = nameVideo + ".mp4";
                UpdateLocalPath();
                Cursor = Cursors.Default;
            }
        }
    }
}
