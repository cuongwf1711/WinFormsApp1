namespace WinFormsApp1
{
    public partial class FormInfo : Form
    {
        private readonly User _user;
        public FormInfo(User user)
        {
            InitializeComponent();

            _user = user;
            panelInfo.BringToFront();
            txtEmail.Text = _user.Email;
            txtFullname.Text = _user.FullName;
        }
        public event Action<User> UserChanged;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            _user.FullName = txtFullname.Text;
            if (_user.Update())
            {
                MessageBox.Show("Done");
                UserChanged?.Invoke(_user);
                Dispose();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            txtOldPass.Text = string.Empty;
            txtNewPass.Text = string.Empty;
            txtNewPassAgain.Text = string.Empty;
            panelPassword.BringToFront();
        }

        private void btnCancelPassword_Click(object sender, EventArgs e)
        {
            panelInfo.BringToFront();
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            if (_user.ChangePassword(txtOldPass.Text, txtNewPass.Text, txtNewPassAgain.Text))
            {
                MessageBox.Show("Done");
                panelInfo.BringToFront();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
