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
            txtURL = new TextBox();
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
            label1.Location = new Point(44, 92);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "URL to download:";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(194, 92);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(948, 27);
            txtURL.TabIndex = 0;
            txtURL.TextChanged += txtURL_TextChanged;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = SystemColors.ActiveCaption;
            btnDownload.Location = new Point(529, 283);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(187, 31);
            btnDownload.TabIndex = 4;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 158);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 0;
            label2.Text = "Local path to save:";
            // 
            // txtLocalpath
            // 
            txtLocalpath.Location = new Point(194, 158);
            txtLocalpath.Name = "txtLocalpath";
            txtLocalpath.Size = new Size(742, 27);
            txtLocalpath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.Window;
            btnBrowse.Location = new Point(942, 158);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(200, 29);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 225);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 2;
            label3.Text = "Connection number:";
            // 
            // cbbConnectNum
            // 
            cbbConnectNum.FormattingEnabled = true;
            cbbConnectNum.Location = new Point(194, 225);
            cbbConnectNum.Name = "cbbConnectNum";
            cbbConnectNum.Size = new Size(619, 28);
            cbbConnectNum.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 494);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1098, 338);
            dataGridView1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(297, 0);
            label4.Name = "label4";
            label4.Size = new Size(489, 60);
            label4.TabIndex = 5;
            label4.Text = "Download Application";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonYTBmp4);
            groupBox1.Controls.Add(radioButtonYTBmp3);
            groupBox1.Controls.Add(radioButtonNone);
            groupBox1.Location = new Point(819, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 60);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // radioButtonYTBmp4
            // 
            radioButtonYTBmp4.AutoSize = true;
            radioButtonYTBmp4.Location = new Point(202, 26);
            radioButtonYTBmp4.Name = "radioButtonYTBmp4";
            radioButtonYTBmp4.Size = new Size(118, 24);
            radioButtonYTBmp4.TabIndex = 0;
            radioButtonYTBmp4.TabStop = true;
            radioButtonYTBmp4.Text = "Youtube mp4";
            radioButtonYTBmp4.UseVisualStyleBackColor = true;
            radioButtonYTBmp4.CheckedChanged += radioButtonYTB_CheckedChanged;
            // 
            // radioButtonYTBmp3
            // 
            radioButtonYTBmp3.AutoSize = true;
            radioButtonYTBmp3.Location = new Point(78, 26);
            radioButtonYTBmp3.Name = "radioButtonYTBmp3";
            radioButtonYTBmp3.Size = new Size(118, 24);
            radioButtonYTBmp3.TabIndex = 0;
            radioButtonYTBmp3.TabStop = true;
            radioButtonYTBmp3.Text = "Youtube mp3";
            radioButtonYTBmp3.UseVisualStyleBackColor = true;
            radioButtonYTBmp3.CheckedChanged += radioButtonYTB_CheckedChanged;
            // 
            // radioButtonNone
            // 
            radioButtonNone.AutoSize = true;
            radioButtonNone.Location = new Point(6, 26);
            radioButtonNone.Name = "radioButtonNone";
            radioButtonNone.Size = new Size(66, 24);
            radioButtonNone.TabIndex = 0;
            radioButtonNone.TabStop = true;
            radioButtonNone.Text = "None";
            radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(44, 430);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1098, 44);
            progressBar1.TabIndex = 7;
            // 
            // labelPercentage
            // 
            labelPercentage.AutoSize = true;
            labelPercentage.Location = new Point(581, 391);
            labelPercentage.Name = "labelPercentage";
            labelPercentage.Size = new Size(33, 20);
            labelPercentage.TabIndex = 8;
            labelPercentage.Text = "0 %";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Info;
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(1032, 391);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 33);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += buttonCancel_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(44, 315);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(69, 20);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Status : ...";
            // 
            // labelFileSize
            // 
            labelFileSize.AutoSize = true;
            labelFileSize.Location = new Point(44, 357);
            labelFileSize.Name = "labelFileSize";
            labelFileSize.Size = new Size(77, 20);
            labelFileSize.TabIndex = 8;
            labelFileSize.Text = "Filesize : ...";
            // 
            // DownloadPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(txtURL);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DownloadPage";
            Size = new Size(1200, 850);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtURL;
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
