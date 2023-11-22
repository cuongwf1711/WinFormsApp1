namespace WinFormsApp1
{
    partial class FormRegister
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
            label1 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtFullname = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 70);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(284, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 27);
            txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 139);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 0;
            label3.Text = "Fullname";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(284, 139);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(271, 27);
            txtFullname.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(380, 223);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(159, 223);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtFullname);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormRegister";
            Text = "FormRegister";
            FormClosed += FormRegister_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtFullname;
        private Button btnConfirm;
        private Button btnCancel;
    }
}