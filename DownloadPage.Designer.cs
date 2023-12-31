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
            label4 = new Label();
            groupBox1 = new GroupBox();
            radioButtonYTBmp4 = new RadioButton();
            radioButtonYTBmp3 = new RadioButton();
            radioButtonNone = new RadioButton();
            progressBar1 = new ProgressBar();
            labelPercentage = new Label();
            btnCancel = new Button();
            labelStatus = new Label();
            labelFileSize = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(38, 71);
            label1.Name = "label1";
            label1.Size = new Size(115, 17);
            label1.TabIndex = 0;
            label1.Text = "URL to download:";
            // 
            // txtUrlDownload
            // 
            txtUrlDownload.Location = new Point(194, 92);
            txtUrlDownload.Name = "txtUrlDownload";
            txtUrlDownload.Size = new Size(948, 27);
            txtUrlDownload.TabIndex = 0;
            txtUrlDownload.TextChanged += txtURL_TextChanged;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.MediumTurquoise;
            btnDownload.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.Location = new Point(463, 212);
            btnDownload.Margin = new Padding(3, 2, 3, 2);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(164, 30);
            btnDownload.TabIndex = 4;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(38, 120);
            label2.Name = "label2";
            label2.Size = new Size(121, 17);
            label2.TabIndex = 0;
            label2.Text = "Local path to save:";
            // 
            // txtLocalpath
            // 
            txtLocalpath.Location = new Point(170, 118);
            txtLocalpath.Margin = new Padding(3, 2, 3, 2);
            txtLocalpath.Name = "txtLocalpath";
            txtLocalpath.Size = new Size(650, 23);
            txtLocalpath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.MediumTurquoise;
            btnBrowse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(824, 118);
            btnBrowse.Margin = new Padding(3, 2, 3, 2);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(175, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(38, 171);
            label3.Name = "label3";
            label3.Size = new Size(133, 17);
            label3.TabIndex = 2;
            label3.Text = "Connection number:";
            // 
            // cbbConnectNum
            // 
            cbbConnectNum.FormattingEnabled = true;
            cbbConnectNum.Location = new Point(170, 169);
            cbbConnectNum.Margin = new Padding(3, 2, 3, 2);
            cbbConnectNum.Name = "cbbConnectNum";
            cbbConnectNum.Size = new Size(542, 23);
            cbbConnectNum.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 370);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1098, 338);
            dataGridView1.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(346, 9);
            label4.Name = "label4";
            label4.Size = new Size(389, 47);
            label4.TabIndex = 5;
            label4.Text = "Download Application";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButtonYTBmp4);
            groupBox1.Controls.Add(radioButtonYTBmp3);
            groupBox1.Controls.Add(radioButtonNone);
            groupBox1.Location = new Point(717, 161);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(283, 45);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // radioButtonYTBmp4
            // 
            radioButtonYTBmp4.AutoSize = true;
            radioButtonYTBmp4.Location = new Point(177, 20);
            radioButtonYTBmp4.Margin = new Padding(3, 2, 3, 2);
            radioButtonYTBmp4.Name = "radioButtonYTBmp4";
            radioButtonYTBmp4.Size = new Size(96, 19);
            radioButtonYTBmp4.TabIndex = 0;
            radioButtonYTBmp4.TabStop = true;
            radioButtonYTBmp4.Text = "Youtube mp4";
            radioButtonYTBmp4.UseVisualStyleBackColor = true;
            radioButtonYTBmp4.CheckedChanged += radioButtonYTB_CheckedChanged;
            // 
            // radioButtonYTBmp3
            // 
            radioButtonYTBmp3.AutoSize = true;
            radioButtonYTBmp3.Location = new Point(68, 20);
            radioButtonYTBmp3.Margin = new Padding(3, 2, 3, 2);
            radioButtonYTBmp3.Name = "radioButtonYTBmp3";
            radioButtonYTBmp3.Size = new Size(96, 19);
            radioButtonYTBmp3.TabIndex = 0;
            radioButtonYTBmp3.TabStop = true;
            radioButtonYTBmp3.Text = "Youtube mp3";
            radioButtonYTBmp3.UseVisualStyleBackColor = true;
            radioButtonYTBmp3.CheckedChanged += radioButtonYTB_CheckedChanged;
            // 
            // radioButtonNone
            // 
            radioButtonNone.AutoSize = true;
            radioButtonNone.Location = new Point(5, 20);
            radioButtonNone.Margin = new Padding(3, 2, 3, 2);
            radioButtonNone.Name = "radioButtonNone";
            radioButtonNone.Size = new Size(54, 19);
            radioButtonNone.TabIndex = 0;
            radioButtonNone.TabStop = true;
            radioButtonNone.Text = "None";
            radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.RosyBrown;
            progressBar1.ForeColor = SystemColors.ControlLightLight;
            progressBar1.Location = new Point(38, 322);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(961, 33);
            progressBar1.TabIndex = 7;
            // 
            // labelPercentage
            // 
            labelPercentage.AutoSize = true;
            labelPercentage.BackColor = Color.Transparent;
            labelPercentage.Location = new Point(528, 298);
            labelPercentage.Name = "labelPercentage";
            labelPercentage.Size = new Size(29, 15);
            labelPercentage.TabIndex = 8;
            labelPercentage.Text = "... %";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Enabled = false;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(903, 293);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 25);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += buttonCancel_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelStatus.Location = new Point(38, 236);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(66, 17);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Status : ...";
            // 
            // labelFileSize
            // 
            labelFileSize.AutoSize = true;
            labelFileSize.BackColor = Color.Transparent;
            labelFileSize.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelFileSize.Location = new Point(38, 268);
            labelFileSize.Name = "labelFileSize";
            labelFileSize.Size = new Size(70, 17);
            labelFileSize.TabIndex = 8;
            labelFileSize.Text = "Filesize : ...";
            // 
            // DownloadPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources._17973908;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnCancel);
            Controls.Add(labelFileSize);
            Controls.Add(labelStatus);
            Controls.Add(labelPercentage);
            Controls.Add(progressBar1);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(cbbConnectNum);
            Controls.Add(btnBrowse);
            Controls.Add(btnDownload);
            Controls.Add(txtLocalpath);
            Controls.Add(txtUrlDownload);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DownloadPage";
            Size = new Size(1050, 638);
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
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton radioButtonYTBmp4;
        private RadioButton radioButtonYTBmp3;
        private RadioButton radioButtonNone;
        private ProgressBar progressBar1;
        private Label labelPercentage;
        private Button btnCancel;
        private Label labelStatus;
        private Label labelFileSize;
    }
}
