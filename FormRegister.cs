namespace WinFormsApp1
{
    public partial class FormRegister : Form
    {
        public event Action RefreshFormlogin;
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshFormlogin?.Invoke();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0 && txtFullname.Text.Length > 0)
            {
                User user = new User() { Email = txtEmail.Text, FullName = txtFullname.Text };
                if (user.Add())
                {
                    MessageBox.Show("Done");
                    Dispose();
                    return;
                }
            }
            MessageBox.Show("Error");
        }
    }
}
