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
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            FirstNameTxt.Text = "";
            LastNameTxt.Text = "";
            AccountNumberTxt.Text = "";
            PhoneNumberTxt.Text = "";
            PasswordTxt2.Text = "";
            ConfirmPasswordTxt.Text = "";
            this.Hide();
            this.SendToBack();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            PasswordTxt2.PasswordChar = '\0';
            Hidebtn.BringToFront();
        }

        private void Hidebtn_Click(object sender, EventArgs e)
        {
            PasswordTxt2.PasswordChar = '*';
            ShowBtn.BringToFront();
        }
    }
}
