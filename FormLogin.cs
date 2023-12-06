using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                user = user.Get();
                if (user != null)
                {
                    Form1 f = new Form1(user);
                    f.RefreshFormlogin += RefreshTextbox;
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister f = new FormRegister();
            f.StartPosition = FormStartPosition.Manual;
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
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
