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

        public List<Transactions> GetAllTransaction(int custID)
        {
            return transRepo.GetAllTransactions(custID);
        }

        public double GetBalance(int custid, int acctid)
        {
            return transRepo.GetBalance(new Transactions(custid, acctid));
            
        }

        public double Deposit(int custID, int acctID, double amount)
        {

            transRepo.AddTransaction(new Transactions(custID, acctID, TransactionType.Deposit, DateTime.Now, amount));
            transRepo.DepositAmount(new Transactions(custID, acctID, TransactionType.Deposit, amount));
            return GetBalance(custID, acctID);
        }

        public double Withdraw(int custID, int acctID, double amount)
        {
            transRepo.AddTransaction(new Transactions(custID, acctID, TransactionType.Withdraw, DateTime.Now, amount));
            transRepo.WithdrawAmount(new Transactions(custID, acctID, TransactionType.Withdraw, amount));
            return GetBalance(custID, acctID);
        }

        public List<Transactions> GetAllAccountBalances(int custID)
        {
            List<Transactions> allBalanceList = transRepo.GetAllBalances(custID);
            return allBalanceList;
        }


        public List<Transactions> GetTransactionsByID(int custID, int acctID)
        {
            return  transRepo.GetTransactionsByAcctID(custID, acctID);
        }

        public void DisplayTransactions(List<Transactions> trans)
        {
            if (trans.Count < 1)
            {
                Console.WriteLine("You don't have any transactions associated with this account type.");
            }
            else
                foreach (var i in trans)
                {
                    Console.WriteLine("Account Type: {0}", i.GetAccountType());
                    Console.WriteLine("Transaction Type: {0}", i.GetTransactionType());
                    Console.WriteLine("Transaction Date: {0}", i.GetDate());
                    Console.WriteLine("Amount: {0}", i.GetAmount());

                    Console.WriteLine();
                }

            //Console.WriteLine("Balance: {0}", transRepo.DisplayBalance(trans[0].GetAccountID(),trans[0].GetCustomerID()));
            
        }

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
