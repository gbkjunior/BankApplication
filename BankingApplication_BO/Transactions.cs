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
        public AccountType accountType;
        public DateTime date;
        public double amount;
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
            return accountType;
        }

        public double GetBalance()
        {
            return this.balance;
        }
        //constructor

    }
}
