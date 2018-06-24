using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_BO
{
    public class CheckingAccount_BO
    {
        int accountID;
        string name;
        public double amount;

        public CheckingAccount_BO()
        {
            this.amount = 100;
        }
    }
}
