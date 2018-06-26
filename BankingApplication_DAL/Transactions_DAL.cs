using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;

namespace BankingApplication_DAL
{
    public class Transactions_DAL
    {
        public static List<Transactions> lstTransactions = new List<Transactions>();

        public void AddTransaction(double amount, double balance, AccountType acctType)
        {
            lstTransactions.Add(new Transactions(TransactionType.Deposit, acctType, DateTime.Now, amount, balance));
            Console.WriteLine(lstTransactions.Count);
        }

        public List<Transactions> GetListTransactions()
        {
            return lstTransactions;
        }

        
        public Transactions_DAL()
        {

        }

        public Transactions_DAL(double amount, double balance, AccountType acctType)
        {
            lstTransactions.Add(new Transactions(TransactionType.Deposit, acctType, DateTime.Now, amount, balance));
        }
    }
}
