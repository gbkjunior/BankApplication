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

        /// <summary>
        /// Constuctor which gets the AccountType from the db and initializes the  AccountType in the BO.
        /// </summary>
        /// <param name="acctType"></param>
        public Accounts(AccountType acctType)
        {
            this.accountType = acctType;
        }
        
        /// <summary>
        /// Get method to retrive AccountType
        /// </summary>
        /// <returns>AccountType</returns>
        public AccountType GetAccountType()
        {
            return accountType;
        }

        /// <summary>
        /// Get method to retrieve AccountID
        /// </summary>
        /// <returns>AccountID</returns>
        public int GetAccountID()
        {
            return this.accountID;
        }

    }
}
