﻿using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;
using System.Linq;
using System.Collections;

namespace BankingApplication_DAL
{
    public class Transactions_DAL
    {
        public void AddTransaction(Transactions trans)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();

            transTable.Transaction_Type = trans.GetTransactionType().ToString();
            transTable.Account_ID = trans.GetAccountID();
            transTable.Customer_ID = trans.GetCustomerID();
            transTable.Transaction_Date = trans.GetDate().ToString();
            transTable.Amount = Convert.ToDecimal(trans.GetAmount());
            
            bankDataContext.TransactionTables.InsertOnSubmit(transTable);
            
            bankDataContext.SubmitChanges();

        }

        /// <summary>
        /// Method to retrieve transactions based on accountID from the db.
        /// </summary>
        /// <param name="custID"></param>
        /// <param name="acctID"></param>
        /// <returns>List of transactions based on the accountID</returns>
        public List<Transactions> GetTransactionsByAcctID(int custID, int acctID)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();
            AccountTable acctTable = new AccountTable();

            var getTransQuery = bankDataContext.TransactionTables.Where(a => (a.Customer_ID == custID && a.Account_ID == acctID));
            
            List<Transactions> getTrans = new List<Transactions>();
            foreach(var i in getTransQuery)
            {
                var getAcctType = bankDataContext.AccountTables.SingleOrDefault(p => p.Account_ID == i.Account_ID).Account_Type;
                
                TransactionType getTransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), i.Transaction_Type);
                AccountType getAccountType = (AccountType)Enum.Parse(typeof(AccountType), getAcctType);
                DateTime getDate = DateTime.ParseExact(i.Transaction_Date, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                
                Transactions transObj = new Transactions(getTransactionType, getAccountType, getDate, Convert.ToDouble(i.Amount));
                getTrans.Add(transObj);
            }

            return getTrans;
        }
        
        /// <summary>
        /// Method to get all the transactions of a customer from the db
        /// </summary>
        /// <param name="custID"></param>
        /// <returns>List of transactions for a customer</returns>
        public List<Transactions> GetAllTransactions(int custID)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();

            var getAllTransQuery = bankDataContext.TransactionTables.Where(t => t.Customer_ID == custID);
            List<Transactions> getAllTrans = new List<Transactions>();

            foreach (var i in getAllTransQuery)
            {
                var getAcctType = bankDataContext.AccountTables.SingleOrDefault(a => a.Account_ID == i.Account_ID).Account_Type;
                
                TransactionType getTransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), i.Transaction_Type);
                AccountType getAccountType = (AccountType)Enum.Parse(typeof(AccountType), getAcctType);
                DateTime getDate = DateTime.ParseExact(i.Transaction_Date, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                
                Transactions getAllTransObj = new Transactions(getTransactionType, getAccountType,getDate, Convert.ToDouble(i.Amount));
                getAllTrans.Add(getAllTransObj);
            }
            return getAllTrans;
        }

        
    }
}
