using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;
using BankingApplication_DAL;

namespace BankingApplication_BLL
{
    public class Accounts_BLL
    {
        Accounts_DAL accountsRepo = new Accounts_DAL();
        Transactions_DAL transRepo = new Transactions_DAL();

        public Accounts_BLL()
        {
           
        }


        public double GetBalance(AccountType acctType)
        {
            var accounts = accountsRepo.GetAccounts();// = 
            double amount = 0;
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].GetAccountType() == acctType)
                {
                    amount = accounts[i].amount;
                }
            }
            return amount;

        }

        public double Deposit(double amount, AccountType acctType)
        {
            var accounts = accountsRepo.GetAccounts();
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].GetAccountType() == acctType)
                    accounts[i].amount += amount;
            }

            var balanceAmount = GetBalance(acctType);
            transRepo.AddTransaction(amount, balanceAmount, acctType);
            //Transactions_DAL trans = new Transactions_DAL(amount, balanceAmount, acctType);
            
            return GetBalance(acctType);
        }

        public double Withdraw(double amount, AccountType acctType)
        {
            var accounts = accountsRepo.GetAccounts();
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].GetAccountType() == acctType)
                    accounts[i].amount -= amount;
            }
            //accountType.amount -= amount;
            double balanceAmount = GetBalance(acctType);

            transRepo.AddTransaction(amount, balanceAmount, acctType);
            //Transactions_DAL trans = new Transactions_DAL(amount, balanceAmount, acctType);
            return GetBalance(acctType);
        }

        //public List<Transactions> GetTransactions(AccountType acctType)
        //{
        //    var accountType = lstTransactions.FindAll(o => o.GetAccountType() == acctType);

        //    List<Transactions> lstObject = new List<Transactions>();
        //    for (int i = 0; i < lstTransactions.Count; i++)
        //    {
        //        if (lstTransactions[i].GetAccountType() == acctType)
        //        {
        //            lstObject = lstTransactions;

        //        }
        //    }
        //    return lstObject;
        //}
        //public void displayTrans(List<Transactions> lstObject, AccountType acctType)
        //{

        //    if (lstObject.Count > 0)
        //    {
        //        Console.WriteLine("The transactions for the {0} account are as follows:", acctType);
        //        foreach (var i in lstObject)
        //        {
        //            Console.WriteLine("Transaction Type: {0}", i.transType);
        //            Console.WriteLine("Transaction Date: {0}", i.getDate());
        //            Console.WriteLine("Amount: {0}", i.getAmount());
        //            Console.WriteLine("Account Balance: {0}", i.GetBalance());
        //        }
        //    }
        //    else
        //        Console.WriteLine("There are no transactions made to this account yet.");



        //}

        //public List<Transactions> GetTransList(AccountType acctType)
        //{
        //    return this.lstTransactions;
        //}

    }
}
