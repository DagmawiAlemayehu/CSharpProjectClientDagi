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
    public partial class Transfer : UserControl
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void ContinueBtn2_Click(object sender, EventArgs e)
        {
            OtherBanksPanel.Visible = false;
            OtherBanksPanel.Hide();
            OtherBanksPanel.SendToBack();
            DialoguePanel.Visible = true;
            DialoguePanel.Show();
            DialoguePanel.BringToFront();

        }

        private void BackBtn2_Click(object sender, EventArgs e)
        {
            OtherBanksPanel.Visible = false;
            OtherBanksPanel.Hide();
            TransferPanel.Visible = true;
            TransferPanel.Show();
            TransferPanel.BringToFront();
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            TransfertoCBEAccPanel.Visible = false;
            TransfertoCBEAccPanel.Hide();
            TransfertoCBEAccPanel.SendToBack();
            DialoguePanel.Visible = true;
            DialoguePanel.Show();
            DialoguePanel.BringToFront();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            TransfertoCBEAccPanel.Visible = false;
            TransfertoCBEAccPanel.Hide();
            TransferPanel.Visible = true;
            TransferPanel.Show();
            TransferPanel.BringToFront();

        }

        private void CBETransferBtn_Click(object sender, EventArgs e)
        {
            TransferPanel.Visible = false;
            TransferPanel.Hide();
            TransfertoCBEAccPanel.Visible = true;
            TransfertoCBEAccPanel.Show();
        }

        private void OtherBanksbtn_Click(object sender, EventArgs e)
        {
            TransferPanel.Visible = false;
            TransferPanel.Hide();
            OtherBanksPanel.Visible = true;
            OtherBanksPanel.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialoguePanel.Visible = false;
            FinalDialoguePanel.Visible = false;
            TransferPanel.Visible = true;
            TransferPanel.Show();
            TransferPanel.BringToFront();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            DialoguePanel.Visible = false;
            DialoguePanel.Hide();

            FinalDialoguePanel.Visible = true;
            FinalDialoguePanel.Show();
            FinalDialoguePanel.BringToFront();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            TransferPanel.Visible = true;
            TransferPanel.Show();
            TransferPanel.BringToFront();
        }

        private void BackButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();
        }
    }
}
