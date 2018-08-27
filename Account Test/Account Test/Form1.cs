using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void GetCDData(CDAccount account)
        {
            decimal interestRate;
            decimal balance;

            account.AccountNumber = accountNumberTextBox.Text;

            account.MaturityDate = maturityDateTextBox.Text;

            if (decimal.TryParse(interestRateTextBox.Text, out interestRate))
            {
                account.InterestRate = interestRate;

                if (decimal.TryParse(balanceTextBox.Text, out balance))
                {
                    account.Balance = balance;
                }
                else
                {
                    MessageBox.Show("invalid balance");
                }
            }
            else
            {
                MessageBox.Show("invalid interest rate");
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CDAccount myAccount = new CDAccount();

            GetCDData(myAccount);

            accountNumberLabel.Text = myAccount.AccountNumber;
            interestRateLabel.Text = myAccount.InterestRate.ToString("n2");
            balanceLabel.Text = myAccount.Balance.ToString("c");
            maturityDateLabel.Text = myAccount.MaturityDate;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
