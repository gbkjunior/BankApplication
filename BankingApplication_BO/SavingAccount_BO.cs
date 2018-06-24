using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_BO
{
    public class SavingAccount_BO
    {
        int accountID;
        string name;
        public double amount;

        public SavingAccount_BO()
        {
            this.amount = 100;
        }
    }
}
