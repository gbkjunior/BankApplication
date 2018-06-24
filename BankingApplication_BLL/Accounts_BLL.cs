using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;

namespace BankingApplication_BLL
{
    public  class Accounts_BLL
    {
        List<Accounts> lstAccounts = new List<Accounts>();
        //List<Transactions> lstTransactions = new List<Transaction>();
        
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
            return GetBalance(acctType);
        }

        public double Withdraw(double amount, AccountType acctType)
        {
            var accountType = lstAccounts.Find(o => o.GetAccountType() == acctType);
            accountType.amount -= amount;
            return GetBalance(acctType);
        }

       

    }
}
