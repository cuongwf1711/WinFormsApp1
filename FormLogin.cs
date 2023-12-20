namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                pictureBoxShow.Hide();
                pictureBoxHide.Show();
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBoxHide.Hide();
                pictureBoxShow.Show();
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void RefreshTextbox()
        {
            Invoke(() =>
            {
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            });
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                User user = new User { Password = txtPassword.Text, Email = txtEmail.Text };
                user = user.Login();
                if (user != null)
                {
                    Form1 f = new Form1(user);
                    f.RefreshFormlogin += RefreshTextbox;
                    f.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Error");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister f = new FormRegister();
            f.Location = Location;
            f.RefreshFormlogin += RefreshTextbox;
            f.ShowDialog();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0)
            {
                User user = new User() { Email = txtEmail.Text };
                if (user.ForgotPassword())
                {
                    MessageBox.Show("Done");
                    return;
                }
            }
            MessageBox.Show("Error");
        }
    }
}
