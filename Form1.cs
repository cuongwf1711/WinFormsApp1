using System.Net.Security;
using YoutubeExplode;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public event Action RefreshFormlogin;
        private readonly FormLogin _formLogin;

        private User _user;
        private int tabCount = 1;

        private readonly HttpClient httpClient = new HttpClient(new SocketsHttpHandler()
        {
            SslOptions = new SslClientAuthenticationOptions
            {
                RemoteCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
            }
        });
        private readonly YoutubeClient youtubeClient = new YoutubeClient();

        public Form1(FormLogin formLogin, User user)
        {
            InitializeComponent();

            _formLogin = formLogin;
            _user = user;
            adminToolStripMenuItem.Text = _user.FullName;

            httpClient.DefaultRequestHeaders.ExpectContinue = false;

            DownloadPage dp = new DownloadPage(httpClient, _user.UserId, youtubeClient);
            dp.Location = new Point(6, 6);
            NewTab1.Controls.Add(dp);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabControl tc = (TabControl)sender;

            if (tc.SelectedTab.Text == "+")
            {
                tabCount++;
                TabPage newTab = new TabPage($"New tab {tabCount}");
                newTab.UseVisualStyleBackColor = true;
                tc.TabPages.Insert(tc.TabCount - 1, newTab);

                DownloadPage dp = new DownloadPage(httpClient, _user.UserId, youtubeClient);
                dp.Location = new Point(6, 6);
                newTab.Controls.Add(dp);

                tc.SelectedTab = newTab;
            }
        }

        private void UpdateUser(User user)
        {
            Invoke(() =>
            {
                _user = user;
                adminToolStripMenuItem.Text = _user.FullName;
            });
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo f = new FormInfo(_user);
            f.UserChanged += UpdateUser;
            f.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            RefreshFormlogin?.Invoke();
            _formLogin.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory f = new FormHistory(_user);
            f.ShowDialog();
        }

        private void deleteTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text != "+")
            {
                TabPage tabDel = tabControl1.SelectedTab;
                tabDel.Dispose();
            }
        }
    }
}