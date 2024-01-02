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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            label1 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtFullname = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(184, 108);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(267, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(431, 34);
            txtEmail.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(164, 200);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.Text = "Fullname:";
            // 
            // txtFullname
            // 
            txtFullname.Anchor = AnchorStyles.None;
            txtFullname.Location = new Point(267, 197);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(431, 34);
            txtFullname.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.None;
            btnConfirm.Location = new Point(440, 274);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(120, 40);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(312, 274);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(378, 9);
            label2.Name = "label2";
            label2.Size = new Size(153, 54);
            label2.Text = "Register";
            // 
            // FormRegister
            // 
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 353);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtFullname);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
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
        private Label label2;
    }
}