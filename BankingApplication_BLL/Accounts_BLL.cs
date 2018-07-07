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
        Customers_DAL custRepo = new Customers_DAL();

        public Accounts_BLL()
        {
            //accountsRepo.AddAccounts(new Accounts(1, AccountType.Checking));
            //accountsRepo.AddAccounts(new Accounts(2, AccountType.Savings));
            //accountsRepo.AddAccounts(new Accounts(3, AccountType.Loan));
        }
        
        public string GetAccountTypeByID(int acctID)
        {
            return accountsRepo.GetAccountType(acctID);
        }

        public double GetBalance(AccountType acctType)
        {
            var customers = custRepo.getLstCustomers();
            var accounts = accountsRepo.GetAccounts(); 
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
            //transRepo.AddTransaction(new Transactions(custID, acctID, TransactionType.Deposit, DateTime.Now, amount));
            return GetBalance(acctType);
        }
        public double GetBalance(int custID, int acctID)
        {

            return transRepo.GetBalance(new Transactions(custID, acctID));
        }

        public void Deposit(int custID, int acctID, double amount)
        {
            
            transRepo.AddTransaction(new Transactions(custID, acctID, TransactionType.Deposit, DateTime.Now, amount));
            //transRepo.DepositAmount(custID, acctID, amount);
            //return GetBalance(custID, acctID);
        }

        public void Withdraw(int custID, int acctID, double amount)
        {
            
            transRepo.AddTransaction(new Transactions(custID, acctID, TransactionType.Withdraw, DateTime.Now, amount));
            //transRepo.WithdrawAmount(custID, acctID, amount);
            //return GetBalance(custID, acctID);
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

        
    }
}
