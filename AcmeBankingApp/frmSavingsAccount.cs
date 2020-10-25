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
    public partial class frmSavingsAccount : Form
    {
        public frmSavingsAccount()
        {
            InitializeComponent();
        }
        
        public long ID { get; set; }
        public long Deposit { get; set; }
        public string Account { get; set; }
        public int Balance { get; set; }
        
        private void frmSavingsAccount_Load(object sender, EventArgs e)
        {
            txtSavingsBalance.Text = Balance.ToString();
            
        }

        private void btnSavingsWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                int amountToWithdraw = Convert.ToInt32(txtSavingsWithdrawAmount.Text);
                SavingsAccount savingsAccount = new SavingsAccount();
                this.Close();
                savingsAccount.withdraw(ID, amountToWithdraw);
                int balance = Balance;
                txtSavingsBalance.Text = Balance.ToString();
            }
            catch 
            {
                MessageBox.Show("Please try again");
            }
            
            
        }

        private void btnSavingsDeposit_Click(object sender, EventArgs e)
        {
            
            try
            {
                int amountToDeposit = Convert.ToInt32(txtSavingsDepositAmount.Text);
                SavingsAccount savingsAccount = new SavingsAccount();
                savingsAccount.deposit(ID, amountToDeposit);
                this.Close();
                int balance = Balance;
                txtSavingsBalance.Text = Balance.ToString();
            }
            catch 
            {
                MessageBox.Show("Please try again");
            }
        }
    }
}
