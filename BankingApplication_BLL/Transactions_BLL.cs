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


        

        public void GetTransactionsByID(int custID, int acctID)
        {
            //List<Transactions> lstObject = new List<Transactions>();
            transRepo.GetTransactionsByAcctID(custID, acctID);
            //return lstObject;

        }



        
    }
}
