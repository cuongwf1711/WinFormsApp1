using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DownloadPage : UserControl
    {
        private readonly HttpClient _httpClient;
        private readonly int _userId;
        public DownloadPage(HttpClient httpClient, int userId)
        {
            _httpClient = httpClient;
            _userId = userId;

            InitializeComponent();

            dataGridView1.DataSource = data;
            cbbConnectNum.Items.AddRange(new object[] { 1, 2, 4, 8, 16, 24, 32 });
            cbbConnectNum.SelectedIndex = 2;
            radioButtonNone.Checked = true;
        }
        private string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        private string fileName = "";
        private CancellationTokenSource cts;
        private BindingList<InfoDownloading> data = new BindingList<InfoDownloading>();
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
        void UpdateLocalPath()
        {
            txtLocalpath.Text = Path.Combine(defaultPath, fileName);
        }
        private void UpdateFileSize(long fileSize)
        {
            Invoke(() =>
            {
                labelFileSize.Text = $"File size : {fileSize} kb";
            });
        }
        private void BeginDownload()
        {
            data.Clear();
            labelStatus.Text = "Status : Downloading";
            btnDownload.Enabled = false;
            btnCancel.Enabled = true;
            progressBar1.Value = 0;
            labelFileSize.Text = "File size : ...";
            radioButtonNone.Checked = true;
        }
        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (txtLocalpath.Text == string.Empty || txtURL.Text == string.Empty)
            {
                MessageBox.Show("Error");
                return;
            }

            if(File.Exists(txtLocalpath.Text))
            {
                DialogResult result = MessageBox.Show("File đã tồn tại, bạn có muốn thêm chỉ số vào không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string extension = Path.GetExtension(fileName);
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

                    int count = 1;
                    string newFileName = $"{fileNameWithoutExtension}({count}){extension}";

                    while (File.Exists(Path.Combine(defaultPath, newFileName)))
                    {
                        count++;
                        newFileName = $"{fileNameWithoutExtension}({count}){extension}";
                    }

                    fileName = newFileName;
                    UpdateLocalPath();
                }
            }
            BeginDownload();
            MyDownloadBooster d = new MyDownloadBooster()
            {
                UrlFileDownload = txtURL.Text,
                LocalPath = txtLocalpath.Text,
                ConnectionNumber = Convert.ToInt32(cbbConnectNum.SelectedItem),
                DateTime = DateTime.Now,
                UserId = _userId
            };
            d.FileSizeUpdated += UpdateFileSize;
            cts = new CancellationTokenSource();
            bool t = false;
            var progress = new Progress<InfoDownloading>(updateDownloading);
            await Task.Run(async () =>
            {
                t = await d.DownloadAsync(progress, _httpClient, cts.Token);
            });
            d.Status = t;
            d.Add();
            EndDownload(d);
        }
        private void EndDownload(MyDownloadBooster d)
        {
            labelStatus.Text = $"Status : {d.Status}";
            labelFileSize.Text = $"File size : {d.FileSize} kb";
            btnDownload.Enabled = true;
            btnCancel.Enabled = false;
            if(d.Status == true)
            {
                DialogResult result = MessageBox.Show($"Downloaded successfully at: {d.LocalPath}, open it", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process process = new System.Diagnostics.Process()
                    {
                        StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = d.LocalPath }
                    };
                    process.Start();
                }
            }
            else
            {
                MessageBox.Show("Download failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        void updateDownloading(InfoDownloading infoDownloading)
        {
            InfoDownloading obj = data.FirstOrDefault(p => p.FileName == infoDownloading.FileName);
            if (infoDownloading.FileName == txtLocalpath.Text)
            {
                labelPercentage.Text = infoDownloading.TotalBytesDownloaded.ToString();
                if (data.Count == 0)
                {
                    data.Add(infoDownloading);
                }
                else
                {
                    obj.BytesSegmentDownloaded = infoDownloading.BytesSegmentDownloaded;
                    data.ResetBindings();
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
                    data.ResetBindings();
                }
                else
                {
                    data.Add(infoDownloading);
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

        private async void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonYTBmp3.Checked == true)
            {
                YtbParse ytbParse = new YtbParse() { UrlOfVideo = txtURL.Text };
                txtURL.Text = await ytbParse.GetUrlDownloadMp3();
                fileName = await ytbParse.GetName() + ".mp3";
                UpdateLocalPath();
            }
            else if(radioButtonYTBmp4.Checked == true)
            {
                YtbParse ytbParse = new YtbParse() { UrlOfVideo = txtURL.Text };
                txtURL.Text = await ytbParse.GetUrlDownloadMp4();
                fileName = await ytbParse.GetName() + ".mp4";
                UpdateLocalPath();
            }
            
        }
    }
}
