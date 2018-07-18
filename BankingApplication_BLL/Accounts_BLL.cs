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
        public Accounts_BLL() { }
        
        public void AddCustomerAccount(int custID, int acctID, double balance)
        {
            accountsRepo.AddCustomerAccount(custID, acctID, balance);
        }
        /// <summary>
        /// Method to Get the account type based on the account ID
        /// </summary>
        /// <param name="acctID"></param>
        /// <returns>Accounts object</returns>
        public Accounts GetAccountTypeByID(int acctID)
        {
            return accountsRepo.GetAccountType(acctID);
        }

        /// <summary>
        /// Method to retrieve the balance of a customer based on his accountID
        /// </summary>
        /// <param name="custid"></param>
        /// <param name="acctid"></param>
        /// <returns>Balance of the given accountID</returns>
        public double GetBalance(int custid, int acctid)
        {
            return accountsRepo.GetBalance(new Transactions(custid, acctid));
        }

        /// <summary>
        /// Method to do the Deposit transaction and get the current balance after deposit
        /// </summary>
        /// <param name="custID"></param>
        /// <param name="acctID"></param>
        /// <param name="amount"></param>
        /// <returns>Current balance after deposit</returns>
        public double Deposit(int custID, int acctID, double amount)
        {
            transRepo.AddTransaction(new Transactions(custID, acctID, TransactionType.Deposit, DateTime.Now, amount));
            accountsRepo.DepositAmount(new Transactions(custID, acctID, TransactionType.Deposit, amount));
            return GetBalance(custID, acctID);
        }

        /// <summary>
        /// Method to do the Withdraw transaction and get the balance after withdraw
        /// </summary>
        /// <param name="custID"></param>
        /// <param name="acctID"></param>
        /// <param name="amount"></param>
        /// <returns>Current balance after Withdraw</returns>
        public double Withdraw(int custID, int acctID, double amount)
        {
            transRepo.AddTransaction(new Transactions(custID, acctID, TransactionType.Withdraw, DateTime.Now, amount));
            accountsRepo.WithdrawAmount(new Transactions(custID, acctID, TransactionType.Withdraw, amount));
            return GetBalance(custID, acctID);
        }

        /// <summary>
        /// Method to get all the account balances of a customer
        /// </summary>
        /// <param name="custID"></param>
        /// <returns>List of transactions with account type and balances</returns>
        public List<Transactions> GetAllAccountBalances(int custID)
        {
            return accountsRepo.GetAllBalances(custID);
        }
    }
}
