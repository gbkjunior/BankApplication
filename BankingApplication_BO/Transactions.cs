using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_BO
{
    public enum TransactionType { Deposit, Withdraw };
    public class Transactions
    {
        //Enum TransactionType // Deposit Withdraw
        int transactionID;
        int customerID;
        int accountID;
        public TransactionType transType;
        private AccountType accountType;
        private DateTime date;
        private double amount;
        private double balance;
        private DateTime now;


        //trancationID
        //transactionType - enum - line 9
        //accountType - enum Accounts.cs
        //date - DateTime - (DateTime.Now)
        //amount 
        //balance


        public Transactions(TransactionType tType, AccountType acctType, DateTime date, double amount, double balance)
        {
            this.transType = tType;
            this.accountType = acctType;
            this.date = date;
            this.amount = amount;
            this.balance = balance;
        }
        public Transactions(AccountType acctType, double balance)
        {
            this.accountType = acctType;
            this.balance = balance;
        }
        public Transactions(TransactionType tType, AccountType acctType, DateTime date, double amount)
        {
            this.transType = tType;
            this.accountType = acctType;
            this.date = date;
            this.amount = amount;
            
        }
        public Transactions(int custID, int acctID)
        {
            this.customerID = custID;
            this.accountID = acctID;
            
        }

        public Transactions(int custID, int acctID, TransactionType tType, double amount)
        {
            this.customerID = custID;
            this.accountID = acctID;
            this.transType = tType;
            this.amount = amount;

        }
        public Transactions(int custID, int acctID, TransactionType tType, DateTime now, double amount)
        {
            this.transType = tType;
            this.accountID = acctID;
            this.customerID = custID;
            this.date = now;
            this.amount = amount;
            
        }

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

        public string GetTransactionType()
        {
            return this.transType.ToString();
        }
        //constructor

    }
}
