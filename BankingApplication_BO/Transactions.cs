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
        private TransactionType deposit;
        private Accounts acctType;
        private DateTime now;
        private object amount1;
        private object p;

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

        public Transactions(TransactionType deposit, Accounts acctType, DateTime now, object amount1, object p)
        {
            this.deposit = deposit;
            this.acctType = acctType;
            this.now = now;
            this.amount1 = amount1;
            this.p = p;
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
