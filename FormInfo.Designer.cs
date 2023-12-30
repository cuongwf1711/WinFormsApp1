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
            panelInfo = new Panel();
            btnChangePassword = new Button();
            btnCancel = new Button();
            btnSaveInfo = new Button();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            btnCancelPassword = new Button();
            btnConfirmPassword = new Button();
            txtNewPassAgain = new TextBox();
            txtNewPass = new TextBox();
            txtOldPass = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            panelPassword.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.PaleTurquoise;
            panelPassword.Controls.Add(panelInfo);
            panelPassword.Controls.Add(label6);
            panelPassword.Controls.Add(btnCancelPassword);
            panelPassword.Controls.Add(btnConfirmPassword);
            panelPassword.Controls.Add(txtNewPassAgain);
            panelPassword.Controls.Add(txtNewPass);
            panelPassword.Controls.Add(txtOldPass);
            panelPassword.Controls.Add(label5);
            panelPassword.Controls.Add(label4);
            panelPassword.Controls.Add(label3);
            panelPassword.Location = new Point(-1, -1);
            panelPassword.Margin = new Padding(3, 2, 3, 2);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(635, 299);
            panelPassword.TabIndex = 0;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.PaleTurquoise;
            panelInfo.Controls.Add(label7);
            panelInfo.Controls.Add(btnChangePassword);
            panelInfo.Controls.Add(btnCancel);
            panelInfo.Controls.Add(btnSaveInfo);
            panelInfo.Controls.Add(txtFullname);
            panelInfo.Controls.Add(txtEmail);
            panelInfo.Controls.Add(label2);
            panelInfo.Controls.Add(label1);
            panelInfo.Location = new Point(2, 1);
            panelInfo.Margin = new Padding(3, 2, 3, 2);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(635, 299);
            panelInfo.TabIndex = 1;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(358, 191);
            btnChangePassword.Margin = new Padding(3, 2, 3, 2);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(146, 25);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Change password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(100, 191);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 25);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.Location = new Point(235, 191);
            btnSaveInfo.Margin = new Padding(3, 2, 3, 2);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(82, 25);
            btnSaveInfo.TabIndex = 4;
            btnSaveInfo.Text = "Save";
            btnSaveInfo.UseVisualStyleBackColor = true;
            btnSaveInfo.Click += btnSaveInfo_Click;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(235, 123);
            txtFullname.Margin = new Padding(3, 2, 3, 2);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(190, 23);
            txtFullname.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.Location = new Point(235, 80);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(190, 23);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(152, 125);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 0;
            label2.Text = "Fullname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(152, 82);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(201, 16);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(183, 21);
            label6.TabIndex = 4;
            label6.Text = "Change your Password";
            // 
            // btnCancelPassword
            // 
            btnCancelPassword.Location = new Point(336, 233);
            btnCancelPassword.Margin = new Padding(3, 2, 3, 2);
            btnCancelPassword.Name = "btnCancelPassword";
            btnCancelPassword.Size = new Size(82, 22);
            btnCancelPassword.TabIndex = 2;
            btnCancelPassword.Text = "Cancel";
            btnCancelPassword.UseVisualStyleBackColor = true;
            btnCancelPassword.Click += btnCancelPassword_Click;
            // 
            // btnConfirmPassword
            // 
            btnConfirmPassword.Location = new Point(163, 233);
            btnConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            btnConfirmPassword.Name = "btnConfirmPassword";
            btnConfirmPassword.Size = new Size(82, 22);
            btnConfirmPassword.TabIndex = 2;
            btnConfirmPassword.Text = "Confirm";
            btnConfirmPassword.UseVisualStyleBackColor = true;
            btnConfirmPassword.Click += btnConfirmPassword_Click;
            // 
            // txtNewPassAgain
            // 
            txtNewPassAgain.Location = new Point(259, 172);
            txtNewPassAgain.Margin = new Padding(3, 2, 3, 2);
            txtNewPassAgain.Name = "txtNewPassAgain";
            txtNewPassAgain.Size = new Size(227, 23);
            txtNewPassAgain.TabIndex = 1;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(259, 123);
            txtNewPass.Margin = new Padding(3, 2, 3, 2);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(227, 23);
            txtNewPass.TabIndex = 1;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(259, 73);
            txtOldPass.Margin = new Padding(3, 2, 3, 2);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(227, 23);
            txtOldPass.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(119, 172);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 0;
            label5.Text = "New password again";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(119, 123);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 0;
            label4.Text = "New password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(119, 73);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 0;
            label3.Text = "Old password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(259, 16);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 21);
            label7.TabIndex = 6;
            label7.Text = "Your Information";
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 297);
            Controls.Add(panelPassword);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label7;
    }
}