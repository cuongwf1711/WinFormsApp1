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
            groupBox1 = new GroupBox();
            radioButtonYTBmp4 = new RadioButton();
            radioButtonYTBmp3 = new RadioButton();
            radioButtonNone = new RadioButton();
            btnCancel = new Button();
            labelStatus = new Label();
            labelFileSize = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(53, 125);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.Text = "URL to download:";
            // 
            // txtUrlDownload
            // 
            txtUrlDownload.Anchor = AnchorStyles.None;
            txtUrlDownload.Location = new Point(204, 124);
            txtUrlDownload.Name = "txtUrlDownload";
            txtUrlDownload.Size = new Size(920, 30);
            txtUrlDownload.TabIndex = 0;
            txtUrlDownload.TextChanged += txtUrlDownload_TextChanged;
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.None;
            btnDownload.BackColor = SystemColors.ActiveCaption;
            btnDownload.Location = new Point(474, 468);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(222, 49);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.Click += btnDownload_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(46, 194);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.Text = "Local path to save:";
            // 
            // txtLocalpath
            // 
            txtLocalpath.Anchor = AnchorStyles.None;
            txtLocalpath.Location = new Point(204, 193);
            txtLocalpath.Name = "txtLocalpath";
            txtLocalpath.Size = new Size(787, 30);
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.None;
            btnBrowse.BackColor = SystemColors.ActiveCaption;
            btnBrowse.Location = new Point(997, 193);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(127, 33);
            btnBrowse.Text = "Browse";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(31, 265);
            label3.Name = "label3";
            label3.Size = new Size(167, 23);
            label3.Text = "Connection number:";
            // 
            // cbbConnectNum
            // 
            cbbConnectNum.Anchor = AnchorStyles.None;
            cbbConnectNum.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbConnectNum.Location = new Point(204, 264);
            cbbConnectNum.Name = "cbbConnectNum";
            cbbConnectNum.Size = new Size(920, 31);
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButtonYTBmp4);
            groupBox1.Controls.Add(radioButtonYTBmp3);
            groupBox1.Controls.Add(radioButtonNone);
            groupBox1.Location = new Point(31, 345);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1093, 101);
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // radioButtonYTBmp4
            // 
            radioButtonYTBmp4.AutoSize = true;
            radioButtonYTBmp4.Location = new Point(870, 49);
            radioButtonYTBmp4.Name = "radioButtonYTBmp4";
            radioButtonYTBmp4.Size = new Size(140, 27);
            radioButtonYTBmp4.TabStop = true;
            radioButtonYTBmp4.Text = "Youtube video";
            radioButtonYTBmp4.CheckedChanged += radioButtonYTB_CheckedChanged;
            // 
            // radioButtonYTBmp3
            // 
            radioButtonYTBmp3.AutoSize = true;
            radioButtonYTBmp3.Location = new Point(472, 49);
            radioButtonYTBmp3.Name = "radioButtonYTBmp3";
            radioButtonYTBmp3.Size = new Size(179, 27);
            radioButtonYTBmp3.TabStop = true;
            radioButtonYTBmp3.Text = "Youtube audio only";
            radioButtonYTBmp3.CheckedChanged += radioButtonYTB_CheckedChanged;
            // 
            // radioButtonNone
            // 
            radioButtonNone.AutoSize = true;
            radioButtonNone.Location = new Point(163, 49);
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
            btnCancel.Location = new Point(997, 468);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 40);
            btnCancel.Text = "Cancel";
            btnCancel.Click += buttonCancel_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Font = new Font("Segoe UI", 19.8000011F);
            labelStatus.Location = new Point(46, 577);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(157, 46);
            labelStatus.Text = "Status : ...";
            // 
            // labelFileSize
            // 
            labelFileSize.AutoSize = true;
            labelFileSize.BackColor = Color.Transparent;
            labelFileSize.Font = new Font("Segoe UI", 19.8000011F);
            labelFileSize.Location = new Point(46, 623);
            labelFileSize.Name = "labelFileSize";
            labelFileSize.Size = new Size(172, 46);
            labelFileSize.Text = "Filesize : ...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(474, 0);
            label4.Name = "label4";
            label4.Size = new Size(194, 81);
            label4.Text = "BASIC UI";
            // 
            // DownloadPage
            // 
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(labelFileSize);
            Controls.Add(labelStatus);
            Controls.Add(btnBrowse);
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
        private GroupBox groupBox1;
        private RadioButton radioButtonYTBmp4;
        private RadioButton radioButtonYTBmp3;
        private RadioButton radioButtonNone;
        private Button btnCancel;
        private Label labelStatus;
        private Label labelFileSize;
        private Label label4;
    }
}
