namespace WinFormsApp1
{
    partial class FormHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            dataGridView1 = new DataGridView();
            btnDel = new Button();
            labelTotal = new Label();
            btnRefresh = new Button();
            labelSelected = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1208, 696);
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Top;
            btnDel.BackColor = Color.White;
            btnDel.Location = new Point(426, 12);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 40);
            btnDel.Text = "Delete";
            btnDel.Click += btnDel_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.Transparent;
            labelTotal.Dock = DockStyle.Left;
            labelTotal.Location = new Point(0, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(54, 28);
            labelTotal.Text = "Total";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top;
            btnRefresh.BackColor = Color.White;
            btnRefresh.Location = new Point(614, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 40);
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // labelSelected
            // 
            labelSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelected.AutoSize = true;
            labelSelected.BackColor = Color.Transparent;
            labelSelected.Location = new Point(12, 766);
            labelSelected.Name = "labelSelected";
            labelSelected.Size = new Size(86, 28);
            labelSelected.Text = "Selected";
            // 
            // FormHistory
            // 
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1232, 803);
            Controls.Add(labelSelected);
            Controls.Add(labelTotal);
            Controls.Add(btnRefresh);
            Controls.Add(btnDel);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDel;
        private Label labelTotal;
        private Button btnRefresh;
        private Label labelSelected;
    }
}