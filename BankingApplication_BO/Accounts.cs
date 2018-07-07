using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_BO
{

    public enum AccountType { Savings, Checking, Loan };

    public class Accounts
    {


        int accountID;
        public double amount;
        private AccountType accountType;


        //Constructors

        public Accounts(int accountID,AccountType acctType)
        {
            
            this.accountID = accountID;
            this.accountType = acctType;
        }

        public Accounts(double amt, AccountType acctType)
        {

            this.amount = amt;
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
        
        public string GetAccountTypeForTable()
        {
            return this.accountType.ToString();
        }
        
    }
}
