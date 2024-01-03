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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            panelPassword = new Panel();
            label6 = new Label();
            btnCancelPassw = new Button();
            btnConfirmPassword = new Button();
            txtNewPassAgain = new TextBox();
            txtNewPass = new TextBox();
            txtOldPass = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panelInfo = new Panel();
            label7 = new Label();
            btnChangePassword = new Button();
            btnCancelInfo = new Button();
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
            panelPassword.Anchor = AnchorStyles.None;
            panelPassword.BackColor = SystemColors.Control;
            panelPassword.BackgroundImage = Properties.Resources.background;
            panelPassword.BackgroundImageLayout = ImageLayout.Stretch;
            panelPassword.Controls.Add(label6);
            panelPassword.Controls.Add(btnCancelPassw);
            panelPassword.Controls.Add(btnConfirmPassword);
            panelPassword.Controls.Add(txtNewPassAgain);
            panelPassword.Controls.Add(txtNewPass);
            panelPassword.Controls.Add(txtOldPass);
            panelPassword.Controls.Add(label5);
            panelPassword.Controls.Add(label4);
            panelPassword.Controls.Add(label3);
            panelPassword.Location = new Point(0, 0);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(885, 355);
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(275, 9);
            label6.Name = "label6";
            label6.Size = new Size(382, 46);
            label6.Text = "Change your Password";
            // 
            // btnCancelPassw
            // 
            btnCancelPassw.Anchor = AnchorStyles.None;
            btnCancelPassw.Location = new Point(337, 282);
            btnCancelPassw.Name = "btnCancelPassw";
            btnCancelPassw.Size = new Size(120, 40);
            btnCancelPassw.Text = "Cancel";
            btnCancelPassw.Click += btnCancel_Click;
            btnCancelPassw.TabIndex = 8;
            // 
            // btnConfirmPassword
            // 
            btnConfirmPassword.Anchor = AnchorStyles.None;
            btnConfirmPassword.Location = new Point(465, 282);
            btnConfirmPassword.Name = "btnConfirmPassword";
            btnConfirmPassword.Size = new Size(120, 40);
            btnConfirmPassword.Text = "Confirm";
            btnConfirmPassword.Click += btnConfirmPassword_Click;
            btnConfirmPassword.TabIndex = 7;
            // 
            // txtNewPassAgain
            // 
            txtNewPassAgain.Anchor = AnchorStyles.None;
            txtNewPassAgain.Location = new Point(288, 214);
            txtNewPassAgain.Name = "txtNewPassAgain";
            txtNewPassAgain.Size = new Size(438, 34);
            txtNewPassAgain.UseSystemPasswordChar = true;
            txtNewPassAgain.TabIndex = 6;
            // 
            // txtNewPass
            // 
            txtNewPass.Anchor = AnchorStyles.None;
            txtNewPass.Location = new Point(288, 145);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(438, 34);
            txtNewPass.UseSystemPasswordChar = true;
            txtNewPass.TabIndex = 5;
            // 
            // txtOldPass
            // 
            txtOldPass.Anchor = AnchorStyles.None;
            txtOldPass.Location = new Point(288, 82);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(438, 34);
            txtOldPass.UseSystemPasswordChar = true;
            txtOldPass.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(84, 217);
            label5.Name = "label5";
            label5.Size = new Size(196, 28);
            label5.Text = "New password again:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(114, 148);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.Text = "New password:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(114, 85);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.Text = "Old password:";
            // 
            // panelInfo
            // 
            panelInfo.Anchor = AnchorStyles.None;
            panelInfo.BackColor = SystemColors.Control;
            panelInfo.BackgroundImage = Properties.Resources.background;
            panelInfo.BackgroundImageLayout = ImageLayout.Stretch;
            panelInfo.Controls.Add(label7);
            panelInfo.Controls.Add(btnChangePassword);
            panelInfo.Controls.Add(btnCancelInfo);
            panelInfo.Controls.Add(btnSaveInfo);
            panelInfo.Controls.Add(txtFullname);
            panelInfo.Controls.Add(txtEmail);
            panelInfo.Controls.Add(label2);
            panelInfo.Controls.Add(label1);
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(885, 355);
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(288, 9);
            label7.Name = "label7";
            label7.Size = new Size(297, 46);
            label7.Text = "Your Information";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.None;
            btnChangePassword.Location = new Point(458, 268);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(200, 40);
            btnChangePassword.Text = "Change password";
            btnChangePassword.Click += btnChangePassword_Click;
            btnChangePassword.TabIndex = 3;
            // 
            // btnCancelInfo
            // 
            btnCancelInfo.Anchor = AnchorStyles.None;
            btnCancelInfo.Location = new Point(202, 268);
            btnCancelInfo.Name = "btnCancelInfo";
            btnCancelInfo.Size = new Size(120, 40);
            btnCancelInfo.Text = "Cancel";
            btnCancelInfo.Click += btnCancel_Click;
            btnCancelInfo.TabIndex = 2;
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.Anchor = AnchorStyles.None;
            btnSaveInfo.Location = new Point(330, 268);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(120, 40);
            btnSaveInfo.Text = "Save";
            btnSaveInfo.Click += btnSaveInfo_Click;
            btnSaveInfo.TabIndex = 1;
            // 
            // txtFullname
            // 
            txtFullname.Anchor = AnchorStyles.None;
            txtFullname.Location = new Point(275, 182);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(416, 34);
            txtFullname.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.Location = new Point(275, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(416, 34);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(172, 185);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.Text = "Fullname:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(190, 105);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.Text = "Email:";
            // 
            // FormInfo
            // 
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 353);
            Controls.Add(panelInfo);
            Controls.Add(panelPassword);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Infomation";
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
        private Button btnSaveInfo;
        private TextBox txtFullname;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private Button btnCancelPassw;
        private Button btnConfirmPassword;
        private TextBox txtNewPassAgain;
        private TextBox txtNewPass;
        private TextBox txtOldPass;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Button btnCancelInfo;
    }
}