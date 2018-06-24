using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;

namespace BankingApplication_BLL
{
    public  class Accounts_BLL
    {
        List<Accounts> lstAccounts = new List<Accounts>();
        List<Transactions> lstTransactions = new List<Transactions>();
        
        public Accounts_BLL()
        {
            lstAccounts.Add(new Accounts(100,AccountType.Checking)); // 3 accounts for each account type
            lstAccounts.Add(new Accounts(100, AccountType.Savings));
            lstAccounts.Add(new Accounts(100, AccountType.Loan));

            

        }


        public double GetBalance(AccountType acctType)
        {
            var accountType = lstAccounts.Find(o => o.GetAccountType() == acctType);
            return accountType.amount;

        }

        public double Deposit(double amount, AccountType acctType)
        {
            var accountType = lstAccounts.Find(o => o.GetAccountType() == acctType);
            accountType.amount += amount;

            lstTransactions.Add(new Transactions(TransactionType.Deposit, acctType, DateTime.Now, amount, GetBalance(acctType)));
            return GetBalance(acctType);
        }

        public double Withdraw(double amount, AccountType acctType)
        {
            var accountType = lstAccounts.Find(o => o.GetAccountType() == acctType);
            accountType.amount -= amount;

            lstTransactions.Add(new Transactions(TransactionType.Withdraw, acctType, DateTime.Now, amount, GetBalance(acctType)));
            return GetBalance(acctType);
        }

        public void GetTransactions(AccountType acctType)
        {
            var accountType = lstTransactions.FindAll(o => o.GetAccountType() == acctType);

            Console.WriteLine("The transactions for the {0} account are as follows:", acctType);
            foreach (var i in accountType)
            {
                Console.WriteLine("Transaction Type: {0}", i.transType);
                Console.WriteLine("Transaction Date: {0}", i.date);
                Console.WriteLine("Amount: {0}", i.amount);
                Console.WriteLine("Account Balance: {0}", i.GetBalance());
            }
        }

    }
}
