namespace WinFormsApp1
{
    partial class FormInfo
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
            panelPassword = new Panel();
            label6 = new Label();
            btnCancelPassword = new Button();
            btnConfirmPassword = new Button();
            txtNewPassAgain = new TextBox();
            txtNewPass = new TextBox();
            txtOldPass = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panelInfo = new Panel();
            btnChangePassword = new Button();
            btnCancel = new Button();
            btnSaveInfo = new Button();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panelPassword.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelPassword
            // 
            panelPassword.Controls.Add(label6);
            panelPassword.Controls.Add(btnCancelPassword);
            panelPassword.Controls.Add(btnConfirmPassword);
            panelPassword.Controls.Add(txtNewPassAgain);
            panelPassword.Controls.Add(txtNewPass);
            panelPassword.Controls.Add(txtOldPass);
            panelPassword.Controls.Add(label5);
            panelPassword.Controls.Add(label4);
            panelPassword.Controls.Add(label3);
            panelPassword.Location = new Point(12, 12);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(704, 375);
            panelPassword.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(230, 21);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(226, 28);
            label6.TabIndex = 4;
            label6.Text = "Change your Password";
            // 
            // btnCancelPassword
            // 
            btnCancelPassword.Location = new Point(384, 311);
            btnCancelPassword.Name = "btnCancelPassword";
            btnCancelPassword.Size = new Size(94, 29);
            btnCancelPassword.TabIndex = 2;
            btnCancelPassword.Text = "Cancel";
            btnCancelPassword.UseVisualStyleBackColor = true;
            btnCancelPassword.Click += btnCancelPassword_Click;
            // 
            // btnConfirmPassword
            // 
            btnConfirmPassword.Location = new Point(186, 311);
            btnConfirmPassword.Name = "btnConfirmPassword";
            btnConfirmPassword.Size = new Size(94, 29);
            btnConfirmPassword.TabIndex = 2;
            btnConfirmPassword.Text = "Confirm";
            btnConfirmPassword.UseVisualStyleBackColor = true;
            btnConfirmPassword.Click += btnConfirmPassword_Click;
            // 
            // txtNewPassAgain
            // 
            txtNewPassAgain.Location = new Point(296, 229);
            txtNewPassAgain.Name = "txtNewPassAgain";
            txtNewPassAgain.Size = new Size(259, 27);
            txtNewPassAgain.TabIndex = 1;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(296, 164);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(259, 27);
            txtNewPass.TabIndex = 1;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(296, 97);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(259, 27);
            txtOldPass.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 229);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 0;
            label5.Text = "New password again";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 164);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 0;
            label4.Text = "New password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 97);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 0;
            label3.Text = "Old password";
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(btnChangePassword);
            panelInfo.Controls.Add(btnCancel);
            panelInfo.Controls.Add(btnSaveInfo);
            panelInfo.Controls.Add(txtFullname);
            panelInfo.Controls.Add(txtEmail);
            panelInfo.Controls.Add(label2);
            panelInfo.Controls.Add(label1);
            panelInfo.Location = new Point(12, 12);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(776, 426);
            panelInfo.TabIndex = 0;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(415, 225);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(167, 29);
            btnChangePassword.TabIndex = 4;
            btnChangePassword.Text = "Change password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(120, 225);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.Location = new Point(256, 225);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(94, 29);
            btnSaveInfo.TabIndex = 3;
            btnSaveInfo.Text = "Save";
            btnSaveInfo.UseVisualStyleBackColor = true;
            btnSaveInfo.Click += btnSaveInfo_Click;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(230, 123);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(217, 27);
            txtFullname.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.Location = new Point(230, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(217, 27);
            txtEmail.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 126);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Fullname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 48);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 396);
            Controls.Add(panelInfo);
            Controls.Add(panelPassword);
            Name = "FormInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPassword;
        private Panel panelInfo;
        private Button btnChangePassword;
        private Button btnCancel;
        private Button btnSaveInfo;
        private TextBox txtFullname;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private Button btnCancelPassword;
        private Button btnConfirmPassword;
        private TextBox txtNewPassAgain;
        private TextBox txtNewPass;
        private TextBox txtOldPass;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
    }
}