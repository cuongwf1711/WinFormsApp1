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
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            btnForgot = new Button();
            pictureBoxHide = new PictureBox();
            pictureBoxShow = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 98);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 166);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(441, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 154);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(441, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(207, 231);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(407, 231);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnForgot
            // 
            btnForgot.Location = new Point(307, 231);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(94, 29);
            btnForgot.TabIndex = 3;
            btnForgot.Text = "Forgot";
            btnForgot.UseVisualStyleBackColor = true;
            btnForgot.Click += btnForgot_Click;
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.Image = (Image)resources.GetObject("pictureBoxHide.Image");
            pictureBoxHide.Location = new Point(633, 154);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(45, 34);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide.TabIndex = 3;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Click += pictureBox1_Click;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.Image = (Image)resources.GetObject("pictureBoxShow.Image");
            pictureBoxShow.Location = new Point(633, 154);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(45, 34);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 3;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(315, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 5;
            label3.Text = "Log In";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 489);
            Controls.Add(label3);
            Controls.Add(btnForgot);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxHide);
            Controls.Add(pictureBoxShow);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnLogin;
        private Button btnForgot;
        private PictureBox pictureBoxHide;
        private PictureBox pictureBoxShow;
        private Label label3;
    }
}