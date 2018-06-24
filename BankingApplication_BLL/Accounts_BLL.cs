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
        CheckingAccount_BO checkingAccount_BO = new CheckingAccount_BO();
        public Accounts_BLL()
        {
            lstAccounts.Add(new Accounts(100,AccountType.Checking)); // 3 accounts for each account type
            lstAccounts.Add(new Accounts(100, AccountType.Savings));
            lstAccounts.Add(new Accounts(100, AccountType.Loan));

            foreach (var o in lstAccounts)
                Console.WriteLine(o.GetAccountType()+" "+ o.amount);
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

        public double Deposit(double amount)//, AccountType accType)
        {
            checkingAccount_BO.amount += amount;
            //Log Transaction (......)

            return GetBalance();
        }


        public double Withdraw(double amount)///)
        {
            return checkingAccount_BO.amount = checkingAccount_BO.amount - amount;
            //Log transaction

        }

        public double GetBalance()
        {
            return checkingAccount_BO.amount;
        }

    }
}
