namespace WinFormsApp1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            btnForgot = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBoxHide = new PictureBox();
            pictureBoxShow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(247, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(441, 34);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(247, 176);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(441, 34);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.Location = new Point(247, 246);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(105, 40);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Location = new Point(553, 246);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnForgot
            // 
            btnForgot.Anchor = AnchorStyles.None;
            btnForgot.Location = new Point(396, 246);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(105, 40);
            btnForgot.TabIndex = 3;
            btnForgot.Text = "Forgot";
            btnForgot.Click += btnForgot_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(366, 9);
            label3.Name = "label3";
            label3.Size = new Size(120, 60);
            label3.Text = "Log In";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(139, 176);
            label2.Name = "label2";
            label2.Size = new Size(102, 34);
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(139, 103);
            label1.Name = "label1";
            label1.Size = new Size(102, 34);
            label1.Text = "Email:";
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.Anchor = AnchorStyles.None;
            pictureBoxHide.BackColor = Color.Transparent;
            pictureBoxHide.Image = (Image)resources.GetObject("pictureBoxHide.Image");
            pictureBoxHide.Location = new Point(694, 176);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(35, 35);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Visible = false;
            pictureBoxHide.Click += pictureBoxShowHide_Click;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.Anchor = AnchorStyles.None;
            pictureBoxShow.BackColor = Color.Transparent;
            pictureBoxShow.Image = (Image)resources.GetObject("pictureBoxShow.Image");
            pictureBoxShow.Location = new Point(694, 176);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(35, 35);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBoxShowHide_Click;
            // 
            // FormLogin
            // 
            ClientSize = new Size(882, 353);
            Controls.Add(pictureBoxShow);
            Controls.Add(pictureBoxHide);
            Controls.Add(label3);
            Controls.Add(btnForgot);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            Text = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnLogin;
        private Button btnForgot;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBoxHide;
        private PictureBox pictureBoxShow;
    }
}