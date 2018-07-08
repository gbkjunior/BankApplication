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
            Console.WriteLine(transRepo.DepositAmount(new Transactions(custID, acctID, TransactionType.Deposit, amount)));
            return GetBalance(custID, acctID);
        }

        public double Withdraw(int custID, int acctID, double amount)
        {

            transRepo.AddTransaction(new Transactions(custID, acctID, TransactionType.Withdraw, DateTime.Now, amount));
            Console.WriteLine(transRepo.WithdrawAmount(new Transactions(custID, acctID, TransactionType.Withdraw, amount)));
            return GetBalance(custID, acctID);
        }




        public List<Transactions> GetTransactionsByID(int custID, int acctID)
        {
            //List<Transactions> lstObject = new List<Transactions>();
            return  transRepo.GetTransactionsByAcctID(custID, acctID);
            //return lstObject;

            

        }

        public void DisplayTransactions(List<Transactions> trans)
        {
            foreach(var i in trans)
            {
                Console.WriteLine("Account Type: {0}", i.GetAccountType());
                Console.WriteLine("Transaction Type: {0}", i.GetTransactionType());
                Console.WriteLine("Transaction Date: {0}", i.GetDate());
                Console.WriteLine("Amount: {0}", i.GetAmount());

            }

            //Console.WriteLine("Balance: {0}", transRepo.DisplayBalance(trans[0].GetAccountID(),trans[0].GetCustomerID()));
            
        }

        
    }
}
