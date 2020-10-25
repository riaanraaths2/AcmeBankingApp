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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            long lIDSelector = 0;
            long lsavingsDeposit = 0;

            if (txtsavingsDeposit.Text != "")
            {
                lsavingsDeposit = long.Parse(txtsavingsDeposit.Text);
            }
            if (txtID.Text != "")
            {
                lIDSelector = long.Parse(txtID.Text);
            }
            else 
            {
                MessageBox.Show("Please enter your Account ID");
            }


            if (radioButton2.Checked )
            {
                try
                {
                    
                    SavingsAccount savingsAccount = new SavingsAccount();
                    //currentAccount.openCurrentAccount(lIDSelector);
                    if (lsavingsDeposit > 999)
                    {
                        savingsAccount.openSavingsAccount(lIDSelector, lsavingsDeposit);
                    }
                    else 
                    {
                        MessageBox.Show("Your savings account requires a deposit of R1000 to access your account");

                    }
                }
                catch
                {
                    MessageBox.Show("Error trying to open your account");
                }
            }
           
            if (radioButton1.Checked)
            {
                txtsavingsDeposit.Enabled = false;
                try
                {
                    
                    CurrentAccount currentAccount =  new CurrentAccount();
                    currentAccount.openCurrentAccount(lIDSelector);
                }
                catch
                {
                    MessageBox.Show("No such account exists");
                }
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Please choose an account type");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtsavingsDeposit.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtsavingsDeposit.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtsavingsDeposit.Enabled = true;
        }
    }
}
