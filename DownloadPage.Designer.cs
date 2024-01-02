namespace WinFormsApp1
{
    partial class DownloadPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUrlDownload = new TextBox();
            btnDownload = new Button();
            label2 = new Label();
            txtLocalpath = new TextBox();
            btnBrowse = new Button();
            label3 = new Label();
            cbbConnectNum = new ComboBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            radioButtonYTBmp4 = new RadioButton();
            radioButtonYTBmp3 = new RadioButton();
            radioButtonNone = new RadioButton();
            btnCancel = new Button();
            labelStatus = new Label();
            labelFileSize = new Label();
            myProgressBar1 = new MyProgressBar();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.Text = "URL to download:";
            // 
            // txtUrlDownload
            // 
            txtUrlDownload.Anchor = AnchorStyles.None;
            txtUrlDownload.Location = new Point(196, 34);
            txtUrlDownload.Name = "txtUrlDownload";
            txtUrlDownload.Size = new Size(920, 30);
            txtUrlDownload.TextChanged += txtUrlDownload_TextChanged;
            txtLocalpath.TabIndex = 0;
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.None;
            btnDownload.BackColor = SystemColors.ActiveCaption;
            btnDownload.Location = new Point(535, 235);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(164, 41);
            btnDownload.Text = "Download";
            btnDownload.Click += btnDownload_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(38, 102);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.Text = "Local path to save:";
            // 
            // txtLocalpath
            // 
            txtLocalpath.Anchor = AnchorStyles.None;
            txtLocalpath.Location = new Point(196, 103);
            txtLocalpath.Name = "txtLocalpath";
            txtLocalpath.Size = new Size(814, 30);
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.None;
            btnBrowse.BackColor = SystemColors.ActiveCaption;
            btnBrowse.Location = new Point(1016, 103);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 30);
            btnBrowse.Text = "Browse";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(23, 174);
            label3.Name = "label3";
            label3.Size = new Size(167, 23);
            label3.Text = "Connection number:";
            // 
            // cbbConnectNum
            // 
            cbbConnectNum.Anchor = AnchorStyles.None;
            cbbConnectNum.FormattingEnabled = true;
            cbbConnectNum.Location = new Point(196, 174);
            cbbConnectNum.Name = "cbbConnectNum";
            cbbConnectNum.Size = new Size(415, 31);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 402);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1051, 295);
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButtonYTBmp4);
            groupBox1.Controls.Add(radioButtonYTBmp3);
            groupBox1.Controls.Add(radioButtonNone);
            groupBox1.Location = new Point(720, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 69);
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // radioButtonYTBmp4
            // 
            radioButtonYTBmp4.Location = new Point(243, 31);
            radioButtonYTBmp4.Name = "radioButtonYTBmp4";
            radioButtonYTBmp4.Size = new Size(133, 27);
            radioButtonYTBmp4.TabStop = true;
            radioButtonYTBmp4.Text = "Youtube mp4";
            radioButtonYTBmp4.CheckedChanged += radioButtonYTB_CheckedChanged;
            // 
            // radioButtonYTBmp3
            // 
            radioButtonYTBmp3.Location = new Point(95, 31);
            radioButtonYTBmp3.Name = "radioButtonYTBmp3";
            radioButtonYTBmp3.Size = new Size(133, 27);
            radioButtonYTBmp3.TabStop = true;
            radioButtonYTBmp3.Text = "Youtube mp3";
            radioButtonYTBmp3.CheckedChanged += radioButtonYTB_CheckedChanged;
            // 
            // radioButtonNone
            // 
            radioButtonNone.Location = new Point(7, 31);
            radioButtonNone.Name = "radioButtonNone";
            radioButtonNone.Size = new Size(73, 27);
            radioButtonNone.TabStop = true;
            radioButtonNone.Text = "None";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Info;
            btnCancel.Enabled = false;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnCancel.Location = new Point(1016, 331);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.Text = "Cancel";
            btnCancel.Click += buttonCancel_Click;
            // 
            // labelStatus
            // 
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Location = new Point(65, 294);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(82, 23);
            labelStatus.Text = "Status : ...";
            // 
            // labelFileSize
            // 
            labelFileSize.BackColor = Color.Transparent;
            labelFileSize.Location = new Point(65, 330);
            labelFileSize.Name = "labelFileSize";
            labelFileSize.Size = new Size(89, 23);
            labelFileSize.Text = "Filesize : ...";
            // 
            // myProgressBar1
            // 
            myProgressBar1.Location = new Point(65, 367);
            myProgressBar1.Name = "myProgressBar1";
            myProgressBar1.Size = new Size(1051, 29);
            // 
            // DownloadPage
            // 
            Controls.Add(myProgressBar1);
            Controls.Add(btnCancel);
            Controls.Add(labelFileSize);
            Controls.Add(labelStatus);
            Controls.Add(btnBrowse);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(cbbConnectNum);
            Controls.Add(btnDownload);
            Controls.Add(txtLocalpath);
            Controls.Add(txtUrlDownload);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "DownloadPage";
            Size = new Size(1200, 700);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUrlDownload;
        private Button btnDownload;
        private Label label2;
        private TextBox txtLocalpath;
        private Button btnBrowse;
        private Label label3;
        private ComboBox cbbConnectNum;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private RadioButton radioButtonYTBmp4;
        private RadioButton radioButtonYTBmp3;
        private RadioButton radioButtonNone;
        private Button btnCancel;
        private Label labelStatus;
        private Label labelFileSize;
        private MyProgressBar myProgressBar1;
    }
}
