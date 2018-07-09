using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;
using BankingApplication_DAL;

namespace BankingApplication_BLL
{
    public class Transactions_BLL 
    {
        Transactions_DAL transRepo = new Transactions_DAL();

        /// <summary>
        /// Method to retrieve all transactions associated with a customerID
        /// </summary>
        /// <param name="custID"></param>
        /// <returns>List of transactions</returns>
        public List<Transactions> GetAllTransaction(int custID)
        {
            return transRepo.GetAllTransactions(custID);
        }

        /// <summary>
        /// Method to retrieve the balance of a customer based on his accountID
        /// </summary>
        /// <param name="custid"></param>
        /// <param name="acctid"></param>
        /// <returns>Balance of the given accountID</returns>
        public double GetBalance(int custid, int acctid)
        {
            return transRepo.GetBalance(new Transactions(custid, acctid));
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
            transRepo.DepositAmount(new Transactions(custID, acctID, TransactionType.Deposit, amount));
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
            transRepo.WithdrawAmount(new Transactions(custID, acctID, TransactionType.Withdraw, amount));
            return GetBalance(custID, acctID);
        }

        /// <summary>
        /// Method to get all the account balances of a customer
        /// </summary>
        /// <param name="custID"></param>
        /// <returns>List of transactions with account type and balances</returns>
        public List<Transactions> GetAllAccountBalances(int custID)
        {
            return transRepo.GetAllBalances(custID);
        }

        /// <summary>
        /// Method to retrieve transactions of a customer for his accountID
        /// </summary>
        /// <param name="custID"></param>
        /// <param name="acctID"></param>
        /// <returns>List of transactions of the given accountID</returns>
        public List<Transactions> GetTransactionsByID(int custID, int acctID)
        {
            return  transRepo.GetTransactionsByAcctID(custID, acctID);
        }

        /// <summary>
        /// Method to display the transactions on the console.
        /// </summary>
        /// <param name="trans"></param>
        public void DisplayTransactions(List<Transactions> trans)
        {
            if (trans.Count < 1)
                Console.WriteLine("You don't have any transactions associated with this account type.");
            else
                foreach (var i in trans)
                {
                    Console.WriteLine("Account Type: {0}", i.GetAccountType());
                    Console.WriteLine("Transaction Type: {0}", i.GetTransactionType());
                    Console.WriteLine("Transaction Date: {0}", i.GetDate());
                    Console.WriteLine("Amount: {0}", i.GetAmount());

                    Console.WriteLine();
                }
        }

        /// <summary>
        /// Method to display all the balances of a customer's accounts on the console.
        /// </summary>
        /// <param name="trans"></param>
        public void DisplayAllBalances(List<Transactions> trans)
        {
            foreach (var i in trans)
            {
                Console.WriteLine("Your balance in {0} account is: {1}", i.GetAccountType(), i.GetBalance());
            }
            Console.WriteLine();
        }
    }
}
