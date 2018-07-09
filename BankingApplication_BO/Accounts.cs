using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_BO
{

    public enum AccountType { Checking = 1, Savings = 2, Loan = 3 };

    public class Accounts
    {
        int accountID;
        private AccountType accountType;
        
        public Accounts(int accountID, AccountType acctType)
        {    
            this.accountID = accountID;
            this.accountType = acctType;
        }

        public Accounts(AccountType acctType)
        {
            this.accountType = acctType;
        }

        public AccountType GetAccountType()
        {
            return accountType;
        }

        public int GetAccountID()
        {
            return this.accountID;
        }

    }
}
