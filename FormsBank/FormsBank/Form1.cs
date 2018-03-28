using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBank
{
    public partial class Form1 : Form
    {
        decimal DepositAmount1;
        decimal DepositAmount2;
        decimal transfer1;
        decimal transfer2;

        Account a1 = new Account();
        Account a2 = new Account();

        public Form1()
        {
            InitializeComponent();
            DisplayBalance();
        }

        public void DisplayBalance()
        {
            lblA1.Text = Convert.ToString($"Balance of a1:  {a1.Balance}  Kr");
            lblA2.Text = Convert.ToString($"Balance of a2:  {a2.Balance}  Kr");

        }

        public static void InsufficiantFunds(decimal amount)
        {
            MessageBox.Show($"Account does not have sufficient funds for that transaction {amount}");
            
            //MessageBox.Show($"{a1.NotEnoughMoneyInAccount(transfer1)} Available funds in the account are {a1.Balance}");

            //MessageBox.Show($" {a1.NotEnoughMoneyInAccount(amount)} Available funds in the account are {a1.Balance}");

        }

        private void txBxDeposit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txBxDeposit1.Text))
                    return;
                DepositAmount1 = decimal.Parse(txBxDeposit1.Text);
                a1.Depostit(DepositAmount1);
                DisplayBalance();
                lstTransaction1.Items.Add($"Deposit:  {txBxDeposit1.Text} Kr\r");

            }

        }

        private void txBxDeposit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txBxDeposit2.Text))
                    return;
                DepositAmount2 = decimal.Parse(txBxDeposit2.Text);
                a2.Depostit(DepositAmount2);
                DisplayBalance();
                lstTransaction2.Items.Add($"Deposit:  {txBxDeposit2.Text} Kr\r");

            }

        }

        private void txBxTrans1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && e.KeyCode != Keys.Back)
            {
                if (string.IsNullOrEmpty(txBxTrans1.Text))
                    return;

                transfer1 = Convert.ToDecimal(txBxTrans1.Text);

                a1.TransferFunds1(a1, a2, transfer1);
                DisplayBalance();
                if (transfer1 <= a2.Balance )
                {
                    lstTransaction1.Items.Add($"Transfer: {txBxTrans1.Text}");
                }
                    txBxTrans1.Clear();
            }
        }

        private void txBxTrans2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && e.KeyCode != Keys.Back)
            {
                if (string.IsNullOrEmpty(txBxTrans2.Text))
                    return;

                transfer2 = Convert.ToDecimal(txBxTrans2.Text);

                
                a2.TransferFunds1(a2, a1, transfer2);

                
                DisplayBalance();
                if (transfer2 <= a2.Balance)
                {
                lstTransaction2.Items.Add($"Transfer: {txBxTrans2.Text}");
                }
                txBxTrans2.Clear();



            }
        }



    }
}


