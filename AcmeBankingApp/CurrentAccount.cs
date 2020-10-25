using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcmeBankingApp
{
    class CurrentAccount : AccountService
    {

        protected static List<SystemDB> users = new List<SystemDB>();
        
                
        public void openSavingsAccount(long accountId, long amountToDeposit)
        {
            
        }
        public void openCurrentAccount(long accountId)
        {
            var users = SystemDB.users;
            int usersCount = users.Count;
            if (accountId -1 < usersCount)
            {
                var _user = users.Where(x => x.ID == accountId).FirstOrDefault();
                if (_user.Account == "Current")
                {
                    //int balance = _user.Balance + Convert.ToInt32(amountToDeposit);
                    long id = _user.ID;
                    string account = _user.Account;


                    frmCurrentAccount formCurrent = new frmCurrentAccount();
                    formCurrent.ID = id;
                    formCurrent.Balance = _user.Balance;
                    formCurrent.Overdraft = _user.Overdraft;
                    formCurrent.Show();
                }
                else 
                {
                    MessageBox.Show("No such account exists"); 
                }

            }
            else
            {
                MessageBox.Show("No such account exists");  
            }
        }
        public void withdraw(long accountId, int amountToWithdraw)
        {
            var users = SystemDB.users;
            var _user = users.Where(x => x.ID == accountId).FirstOrDefault();
            int Availablebalance = _user.Balance + _user.Overdraft;
            // int newBalance = balance + Convert.ToInt32(deposit);
            long id = _user.ID;

            if (Availablebalance > amountToWithdraw )
            {
               
                    _user.Balance = _user.Balance - amountToWithdraw;
                
                
                frmCurrentAccount formCurrent = new frmCurrentAccount();
                formCurrent.Balance = _user.Balance;
                formCurrent.Overdraft = _user.Overdraft;
                formCurrent.ID = _user.ID;
                formCurrent.Show();
            }
            else
            {
                MessageBox.Show("You cannot draw more than your available balance");
                frmCurrentAccount formCurrent = new frmCurrentAccount();
                formCurrent.Balance = _user.Balance;
                formCurrent.Overdraft = _user.Overdraft;
                formCurrent.ID = _user.ID;
                formCurrent.Show();
            }


        }
        public void deposit(long accountId, int amountToDeposit)
        {
            try
            {
                var users = SystemDB.users;
                var _user = users.Where(x => x.ID == accountId).FirstOrDefault();
                int balance = _user.Balance;
                // int newBalance = balance + Convert.ToInt32(deposit);
                long id = _user.ID;
                _user.Balance = _user.Balance + amountToDeposit;
                frmCurrentAccount formCurrent = new frmCurrentAccount();
                formCurrent.Balance = _user.Balance;
                formCurrent.Overdraft = _user.Overdraft;
                formCurrent.ID = _user.ID;
                formCurrent.Show();
            }
            catch
            {
                MessageBox.Show("unable to make your deposit");
                
            }
        }
    }
}
