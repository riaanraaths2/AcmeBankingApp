using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeBankingApp
{
    public interface AccountService
    {
         void openSavingsAccount(long accountId, long amountToDeposit);
         void openCurrentAccount(long accountId);
         void withdraw(long accountId, int amountToWithdraw);
       // throws AccountNotFoundException, WithdrawalAmountTooLargeException;
         void deposit(long accountId, int amountToDeposit);
    }
   
}
