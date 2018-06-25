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
        public TransactionType transType;
        private AccountType accountType;
        private DateTime date;
        private double amount;
        private double balance;
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

        public AccountType GetAccountType()
        {
            return this.accountType;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public DateTime getDate()
        {
            return this.date;
        }

        public double getAmount()
        {
            return this.amount;
        }
        //constructor

    }
}
