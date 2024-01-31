using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_BankingSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void PasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheckBox.Checked)
            {
                PasswordTxt.PasswordChar = '\0';
            }
            else
            {
                PasswordTxt.PasswordChar = '*';
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            Usernametxt.Text = "";
            PasswordTxt.Text = "";
            signUp1.Visible = true;
            signUp1.BringToFront();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new ();
            mainPage.ShowDialog();
            this.Close();
        }


        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
