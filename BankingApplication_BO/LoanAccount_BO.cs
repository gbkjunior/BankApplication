using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_BO
{
    public class LoanAccount_BO
    {
        int accountID;
        string name;
        public double amount;

        public LoanAccount_BO()
        {
            this.amount = 100;
        }
    }
}
