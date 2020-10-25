using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcmeBankingApp
{
    public class SavingsAccount: AccountService
    {
        protected static List<SystemDB> users = new List<SystemDB>();
        
        public void openSavingsAccount(long accountId, long amountToDeposit)
        {
            var users = SystemDB.users;
            int usersCount = users.Count;
            if (accountId -1 < usersCount)
            {
                var _user = users.Where(x => x.ID == accountId).FirstOrDefault();
                if (_user.Account == "Savings")
                {

                    int balance = _user.Balance + Convert.ToInt32(amountToDeposit);
                    long id = _user.ID;
                    string account = _user.Account;
                    long deposit = amountToDeposit;
                    if (deposit > 999)
                    {
                        frmSavingsAccount formSavings = new frmSavingsAccount();
                        formSavings.ID = id;
                        formSavings.Deposit = deposit;
                        _user.Balance = balance;
                        formSavings.Balance = _user.Balance;
                        formSavings.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please deposit atleast R1000 before you can open your account.");
                        frmSavingsAccount formSavings = new frmSavingsAccount();
                        formSavings.ID = id;
                        formSavings.Balance = _user.Balance;
                        formSavings.Show();
                    }

                }
                else 
                {
                    MessageBox.Show("You do not have a savings account");
                }
            }
            else 
            {
                MessageBox.Show("No such account exists");
            }

        }
        public void openCurrentAccount(long accountId)
        {

        }
        public void withdraw(long accountId, int amountToWithdraw)
        {
            var users = SystemDB.users;
            var _user = users.Where(x => x.ID == accountId).FirstOrDefault();
            int balance = _user.Balance;
           // int newBalance = balance + Convert.ToInt32(deposit);
            long id = _user.ID;
            if (balance - amountToWithdraw > 999)
            {
                _user.Balance = _user.Balance - amountToWithdraw;
                frmSavingsAccount formSavings = new frmSavingsAccount();
                formSavings.Balance = _user.Balance;
                formSavings.ID = _user.ID;
                formSavings.Show();
            }
            else 
            {
                MessageBox.Show("You cannot have less than R1000 in your savings account");
                frmSavingsAccount formSavings = new frmSavingsAccount();
                formSavings.Balance = _user.Balance;
                formSavings.ID = _user.ID;
                formSavings.Show();
            }
           
           
        }
        public void deposit(long accountId, int amountToDeposit)
        {
            var users = SystemDB.users;
            var _user = users.Where(x => x.ID == accountId).FirstOrDefault();
                int balance = _user.Balance;
                // int newBalance = balance + Convert.ToInt32(deposit);
                long id = _user.ID;
                _user.Balance = _user.Balance + amountToDeposit;
                frmSavingsAccount formSavings = new frmSavingsAccount();
                formSavings.Balance = _user.Balance;
                formSavings.ID = _user.ID;
                formSavings.Show();
        }
    }
}
