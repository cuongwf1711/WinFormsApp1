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
            label6 = new Label();
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
            panelPassword.Location = new Point(20, 19);
            panelPassword.Margin = new Padding(5, 5, 5, 5);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(1144, 600);
            panelPassword.TabIndex = 0;
            // 
            // btnCancelPassword
            // 
            btnCancelPassword.Location = new Point(624, 498);
            btnCancelPassword.Margin = new Padding(5, 5, 5, 5);
            btnCancelPassword.Name = "btnCancelPassword";
            btnCancelPassword.Size = new Size(153, 46);
            btnCancelPassword.TabIndex = 2;
            btnCancelPassword.Text = "Cancel";
            btnCancelPassword.UseVisualStyleBackColor = true;
            btnCancelPassword.Click += btnCancelPassword_Click;
            // 
            // btnConfirmPassword
            // 
            btnConfirmPassword.Location = new Point(302, 498);
            btnConfirmPassword.Margin = new Padding(5, 5, 5, 5);
            btnConfirmPassword.Name = "btnConfirmPassword";
            btnConfirmPassword.Size = new Size(153, 46);
            btnConfirmPassword.TabIndex = 2;
            btnConfirmPassword.Text = "Confirm";
            btnConfirmPassword.UseVisualStyleBackColor = true;
            btnConfirmPassword.Click += btnConfirmPassword_Click;
            // 
            // txtNewPassAgain
            // 
            txtNewPassAgain.Location = new Point(481, 367);
            txtNewPassAgain.Margin = new Padding(5, 5, 5, 5);
            txtNewPassAgain.Name = "txtNewPassAgain";
            txtNewPassAgain.Size = new Size(418, 39);
            txtNewPassAgain.TabIndex = 1;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(481, 263);
            txtNewPass.Margin = new Padding(5, 5, 5, 5);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(418, 39);
            txtNewPass.TabIndex = 1;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(481, 155);
            txtOldPass.Margin = new Padding(5, 5, 5, 5);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(418, 39);
            txtOldPass.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 367);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(233, 32);
            label5.TabIndex = 0;
            label5.Text = "New password again";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 263);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 32);
            label4.TabIndex = 0;
            label4.Text = "New password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 155);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 32);
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
            panelInfo.Location = new Point(20, 19);
            panelInfo.Margin = new Padding(5, 5, 5, 5);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1261, 682);
            panelInfo.TabIndex = 0;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(674, 360);
            btnChangePassword.Margin = new Padding(5, 5, 5, 5);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(271, 46);
            btnChangePassword.TabIndex = 2;
            btnChangePassword.Text = "Change password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(195, 360);
            btnCancel.Margin = new Padding(5, 5, 5, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(153, 46);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.Location = new Point(416, 360);
            btnSaveInfo.Margin = new Padding(5, 5, 5, 5);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(153, 46);
            btnSaveInfo.TabIndex = 2;
            btnSaveInfo.Text = "Save";
            btnSaveInfo.UseVisualStyleBackColor = true;
            btnSaveInfo.Click += btnSaveInfo_Click;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(374, 197);
            txtFullname.Margin = new Padding(5, 5, 5, 5);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(350, 39);
            txtFullname.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.Location = new Point(374, 72);
            txtEmail.Margin = new Padding(5, 5, 5, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(350, 39);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 202);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 0;
            label2.Text = "Fullname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 77);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(374, 33);
            label6.Name = "label6";
            label6.Size = new Size(362, 45);
            label6.TabIndex = 4;
            label6.Text = "Change your Password";
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 633);
            Controls.Add(panelPassword);
            Controls.Add(panelInfo);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormInfo";
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