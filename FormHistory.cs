using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class FormHistory : Form
    {
        private readonly User _user;
        public FormHistory(User user)
        {
            InitializeComponent();
            _user = user;
            RefreshDgv();
        }
        private void RefreshDgv()
        {
            dataGridView1.DataSource = StaticFunc.ToDataTable(_user.GetMyDownloads());
            dataGridView1.Columns["UserId"].Visible = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    MyDownloadBooster myDownloadBooster = new MyDownloadBooster() { MyDownloadBoosterId = Convert.ToInt32(r.Cells["MyDownloadBoosterId"].Value) };
                    myDownloadBooster = myDownloadBooster.Get();
                    if (myDownloadBooster == null || !myDownloadBooster.Delete())
                    {
                        MessageBox.Show("Error");
                        RefreshDgv();
                        return;
                    }
                }
                RefreshDgv();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 1 || e.ColumnIndex == 2))
            {
                string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Process process = new System.Diagnostics.Process()
                {
                    StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = value }
                };
                try
                {
                    process.Start();
                }
                catch 
                {
                    MessageBox.Show("File path doesn't exist or be changed");
                }
            }
        }
    }
}
