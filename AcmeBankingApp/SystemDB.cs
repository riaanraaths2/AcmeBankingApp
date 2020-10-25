using 
    System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeBankingApp
{
    
    public class SystemDB
    {
 
       
        public long ID { get; set; }
        public string Account { get; set; }
        public int Balance { get; set; }
        public int Overdraft { get; set; }
       

        public SystemDB(long userID, string account, int balance, int overdraft)
        {
            ID = userID;
            Account = account;
            Balance = balance;
            Overdraft = overdraft;
        }
        public static List<SystemDB> users = new List<SystemDB>
                {
                    new SystemDB(3, "Current", 1000, 10000),
                    new SystemDB(4, "Current", 5000, 20000),
                    new SystemDB(1, "Savings", 2000, 0),
                    new SystemDB(2, "Savings", 5000, 0)
                };

    }
    
}
