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

        public void GetAllTransaction(int custID)
        {
            transRepo.GetAllTransactions(custID);
        }

        //public double GetBalance(int custID, int acctID)
        //{

        //    return transRepo.GetBalance(new Transactions(custID, acctID));
        //}

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




        public void GetTransactionsByID(int custID, int acctID)
        {
            //List<Transactions> lstObject = new List<Transactions>();
            transRepo.GetTransactionsByAcctID(custID, acctID);
            //return lstObject;

        }



        
    }
}
