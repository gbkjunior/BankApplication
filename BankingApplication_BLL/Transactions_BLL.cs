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

        public List<Transactions> GetTransactions(AccountType acctType)
        {
            List<Transactions> lstObject = new List<Transactions>();
            for (int i = 0; i < transRepo.GetListTransactions().Count; i++)
            {
                if (transRepo.GetListTransactions()[i].GetAccountType() == acctType)
                {
                    lstObject.Add(transRepo.GetListTransactions()[i]) ;

                }
            }
            return lstObject;

        }


        public void displayTransactions(List<Transactions> lstObject, AccountType acctType)
        {
            if(lstObject.Count > 0)
            {
                Console.WriteLine("The transactions for the {0} account are as follows:", acctType);
                foreach (var i in lstObject)
                {
                    Console.WriteLine("Transaction Type: {0}", i.transType);
                    Console.WriteLine("Transaction Date: {0}", i.getDate());
                    Console.WriteLine("Amount: {0}", i.getAmount());
                    Console.WriteLine("Account Balance: {0}", i.GetBalance());
                }
            }
            else
                Console.WriteLine("There are no transactions made to this account yet.");

        }
    }
}
