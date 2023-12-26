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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 388);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(244, 12);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(129, 29);
            btnDel.TabIndex = 1;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(738, 27);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(40, 20);
            labelTotal.TabIndex = 2;
            labelTotal.Text = "total";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(421, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(133, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // labelSelected
            // 
            labelSelected.AutoSize = true;
            labelSelected.Location = new Point(12, 27);
            labelSelected.Name = "labelSelected";
            labelSelected.Size = new Size(64, 20);
            labelSelected.TabIndex = 2;
            labelSelected.Text = "selected";
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSelected);
            Controls.Add(labelTotal);
            Controls.Add(btnRefresh);
            Controls.Add(btnDel);
            Controls.Add(dataGridView1);
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