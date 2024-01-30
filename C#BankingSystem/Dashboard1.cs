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
    public partial class Dashboard1 : UserControl
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void ShowBalancebtn_Click(object sender, EventArgs e)
        {
            Balancelbl.Text = "$ 1,800,000 Birr";
            AccountNumlbl.Text = "100361545803";
            HideBalancebtn.BringToFront();
        }

        private void HideBalancebtn_Click(object sender, EventArgs e)
        {
            Balancelbl.Text = "$ ******* Birr";
            AccountNumlbl.Text = "1******5803";
            ShowBalancebtn.BringToFront();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }
    }
}
