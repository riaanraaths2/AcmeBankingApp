using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcmeBankingApp
{
    public partial class frmCurrentAccount : Form
    {
        public frmCurrentAccount()
        {
            InitializeComponent();
        }
        public long ID { get; set; }
        public long Deposit { get; set; }
        public string Account { get; set; }
        public int Balance { get; set; }
        public int Overdraft { get; set; }

        private void btnCurrentWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                int amountToWithdraw = Convert.ToInt32(txtCurrentWithdrawAmount.Text);
                CurrentAccount currentAccount = new CurrentAccount();
                this.Close();
                currentAccount.withdraw(ID, amountToWithdraw);
                int balance = Balance;
                txtCurrentBalance.Text = Balance.ToString();
                txtAvailableBalance.Text = (Overdraft + Balance).ToString();
                
            }
            catch
            {
                MessageBox.Show("Please try again");
            }
        }

        private void btnCurrentDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                int amountToDeposit = Convert.ToInt32(txtCurrentDepositAmount.Text);
                CurrentAccount currentAccount = new CurrentAccount();
                currentAccount.deposit(ID, amountToDeposit);
                this.Close();
                int balance = Balance;
                txtAvailableBalance.Text = (Overdraft + Balance).ToString();
                txtCurrentBalance.Text = Balance.ToString();
            }
            catch
            {
                MessageBox.Show("Please try again");
            }
        }

        private void frmCurrentAccount_Load(object sender, EventArgs e)
        {
            txtCurrentBalance.Text = Balance.ToString();
            txtAvailableBalance.Text = (Overdraft + Balance).ToString();
        }
    }
}
