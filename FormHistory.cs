using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class FormHistory : Form
    {
        private readonly User _user;
        private readonly ContextMenuStrip cellContextMenu = new ContextMenuStrip();
        private DataGridViewCell selectedCell;

        private void InitializeContextMenu()
        {
            ToolStripMenuItem itemOpenFile = new ToolStripMenuItem("Open file");
            itemOpenFile.Click += itemOpenFile_Click;
            cellContextMenu.Items.Add(itemOpenFile);

            ToolStripMenuItem itemOpenFolder = new ToolStripMenuItem("Open folder");
            itemOpenFolder.Click += itemOpenFolder_Click;
            cellContextMenu.Items.Add(itemOpenFolder);
        }

        private void itemOpenFile_Click(object sender, EventArgs e)
        {
            if (selectedCell != null)
            {
                if (!OpenFile(selectedCell.Value.ToString()))
                {
                    MessageBox.Show("Path doesn't exist or has been changed");
                }
            }
        }

        private void itemOpenFolder_Click(object sender, EventArgs e)
        {
            if (selectedCell != null)
            {
                if (!OpenFile(Path.GetDirectoryName(selectedCell.Value.ToString())))
                {
                    MessageBox.Show("Path doesn't exist or has been changed");
                }
            }
        }

        public FormHistory(User user)
        {
            _user = user;

            InitializeComponent();
            InitializeContextMenu();

            RefreshDgv();
        }

        private void RefreshDgv()
        {
            dataGridView1.DataSource = StaticFunc.ToDataTable(_user.GetMyDownloads());
            dataGridView1.Columns["UserId"].Visible = false;
            dataGridView1.Columns["MyDownloadBoosterId"].Visible = false;

            labelTotal.Text = $"total: {dataGridView1.Rows.Count}";
            labelSelected.Text = "selected: 0";
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

        private bool OpenFile(string path)
        {
            try
            {
                ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = path;
                startInfo.UseShellExecute = true;

                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if(!OpenFile(value))
                {
                    MessageBox.Show("Path doesn't exist or has been changed");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                labelSelected.Text = $"selected: {dataGridView1.SelectedRows.Count}";
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.ClearSelection();
                if (e.RowIndex >= 0 && e.ColumnIndex == 2) 
                {
                    selectedCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                    selectedCell.Selected = true;

                    Point relativeMousePosition = dataGridView1.PointToClient(Cursor.Position);
                    cellContextMenu.Show(dataGridView1, relativeMousePosition);
                }
            }
        }
    }
}
