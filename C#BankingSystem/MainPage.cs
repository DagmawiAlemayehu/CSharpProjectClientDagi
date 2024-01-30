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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExpandBtn_Click(object sender, EventArgs e)
        {

            SidebarTransiton.Start();
        }

        bool sidebarExpand = true;
        private void SidebarTransiton_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                sidebarGradientPanel.Width -= 10;
                if (sidebarGradientPanel.Width <= 124)
                {
                    sidebarExpand = false;
                    AccountPictureBox.Visible = false;
                    NameLbl.Visible = false;
                    SidebarTransiton.Stop();
                }
            }
            else
            {

                sidebarGradientPanel.Width += 10;
                if (sidebarGradientPanel.Width >= 366)
                {
                    sidebarExpand = true;
                    AccountPictureBox.Visible = true;
                    NameLbl.Visible = true;
                    SidebarTransiton.Stop();

                    Dashboardbtn.Width = sidebarGradientPanel.Width;
                    Transferbtn.Width = sidebarGradientPanel.Width;
                    Newsbtn.Width = sidebarGradientPanel.Width;
                    Recentsbtn.Width = sidebarGradientPanel.Width;
                    Supportbtn.Width = sidebarGradientPanel.Width;
                    Logoutbtn.Width = sidebarGradientPanel.Width;
                }
            }
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            dashboard11.Visible = true;
            dashboard11.Show();
            dashboard11.BringToFront();
        }

        private void Newsbtn_Click(object sender, EventArgs e)
        {
            news1.Visible = true;
            news1.Show();
            news1.BringToFront();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            login = null;
            this.Close();
        }

        private void Supportbtn_Click(object sender, EventArgs e)
        {
            settings1.Visible = true;
            settings1.Show();
            settings1.BringToFront();
        }

        private void Recentsbtn_Click(object sender, EventArgs e)
        {
            recent_Transactions1.Visible = true;
            recent_Transactions1.Show();
            recent_Transactions1.BringToFront();
        }
    }
}
