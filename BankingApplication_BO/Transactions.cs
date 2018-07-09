using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_BO
{
    public enum TransactionType { Deposit, Withdraw };
    public class Transactions
    {
        int transactionID;
        private int customerID;
        private int accountID;
        public TransactionType transType;
        private AccountType accountType;
        private DateTime date;
        private double amount;
        private double balance;

        /// <summary>
        /// Constructor used to get all balances for all the accounts
        /// </summary>
        /// <param name="acctType"></param>
        /// <param name="balance"></param>
        public Transactions(AccountType acctType, double balance)
        {
            this.accountType = acctType;
            this.balance = balance;
        }

        /// <summary>
        /// Constructor used to get the transactions based on account ID
        /// </summary>
        /// <param name="tType"></param>
        /// <param name="acctType"></param>
        /// <param name="date"></param>
        /// <param name="amount"></param>
        public Transactions(TransactionType tType, AccountType acctType, DateTime date, double amount)
        {
            this.transType = tType;
            this.accountType = acctType;
            this.date = date;
            this.amount = amount;   
        }

        /// <summary>
        /// Constructor to get the balance of a customer and his/her account ID
        /// </summary>
        /// <param name="custID"></param>
        /// <param name="acctID"></param>
        public Transactions(int custID, int acctID)
        {
            this.customerID = custID;
            this.accountID = acctID; 
        }

        /// <summary>
        /// Constructor used when a deposit/withdraw is made in order to update the balance 
        /// </summary>
        /// <param name="custID"></param>
        /// <param name="acctID"></param>
        /// <param name="tType"></param>
        /// <param name="amount"></param>
        public Transactions(int custID, int acctID, TransactionType tType, double amount)
        {
            this.customerID = custID;
            this.accountID = acctID;
            this.transType = tType;
            this.amount = amount;
        }

        /// <summary>
        /// Constructor to add a new transaction
        /// </summary>
        /// <param name="custID"></param>
        /// <param name="acctID"></param>
        /// <param name="tType"></param>
        /// <param name="now"></param>
        /// <param name="amount"></param>
        public Transactions(int custID, int acctID, TransactionType tType, DateTime now, double amount)
        {
            this.transType = tType;
            this.accountID = acctID;
            this.customerID = custID;
            this.date = now;
            this.amount = amount;
        }

        /// <summary>
        /// Get methods to retrive the member variables of this BO
        /// </summary>
        /// <returns>AccountType, TransactionType, Balance, AccountID, CustomerID, TransactionDate, Amount</returns>

        public AccountType GetAccountType()
        {
            return this.accountType;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public int GetAccountID()
        {
            return this.accountID;
        }

        public int GetCustomerID()
        {
            return this.customerID;
        }

        public DateTime GetDate()
        {
            return this.date;
        }

        public double GetAmount()
        {
            return this.amount;
        }
        
        public TransactionType GetTransactionType()
        {
            return this.transType;
        }
    }
}
