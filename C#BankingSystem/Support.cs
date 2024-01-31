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
    public partial class Support : UserControl
    {
        public Support()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }
        private void ContactUsbtn_Click(object sender, EventArgs e)
        {
            ContactUsBox.Visible = true;
            ContactUsBox.Show();
            ContactUsBox.BringToFront();
        }
        private void Supportbtn_Click(object sender, EventArgs e)
        {
            SupportBox.Visible = true;
            SupportBox.Show();
            SupportBox.BringToFront();
        }
    }
}
