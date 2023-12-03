namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public event Action RefreshFormlogin;
        private User _user;
        private int tabCount = 1;

        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()
        {
            ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
        });
        public Form1(User user)
        {
            InitializeComponent();
            _user = user;
            adminToolStripMenuItem.Text = _user.FullName;
            DownloadPage dp = new DownloadPage(httpClient, _user.UserId);
            dp.Location = new Point(6, 6);
            NewTab1.Controls.Add(dp);
        }

        private void btnDelTab_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text != "+")
            {
                TabPage tab = tabControl1.SelectedTab;
                foreach (Control control in tab.Controls)
                {
                    control.Dispose();
                }
                tabControl1.TabPages.Remove(tab);
            }
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

                DownloadPage dp = new DownloadPage(httpClient, _user.UserId);
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
            RefreshFormlogin?.Invoke();
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
    }
}