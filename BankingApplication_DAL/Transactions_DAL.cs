using System;
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

            transTable.Transaction_Type = trans.GetTransactionType();
            transTable.Account_ID = trans.GetAccountID();
            transTable.Customer_ID = trans.GetCustomerID();
            transTable.Transaction_Date = trans.GetDate().ToString();
            transTable.Amount = trans.GetAmount();

            //transTable.Customer_Accounts_Table.Account_ID = trans.GetAccountID();
            //transTable.Customer_Accounts_Table.Customer_ID = trans.GetCustomerID();
            //transTable.Customer_Accounts_Table.Balance = trans.getAmount();


            
            bankDataContext.TransactionTables.InsertOnSubmit(transTable);
            
            bankDataContext.SubmitChanges();

        }

        public List<Transactions> GetTransactionsByAcctID(int custID, int acctID)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();
            AccountTable acctTable = new AccountTable();

            var getTransQuery = bankDataContext.TransactionTables.Where(a => (a.Customer_ID == custID && a.Account_ID == acctID));


            List<Transactions> getTrans = new List<Transactions>();
            foreach(var i in getTransQuery)
            {
                var getAcctType = bankDataContext.AccountTables.Single(p => p.Account_ID == i.Account_ID).Account_Type;
                

                TransactionType getTransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), i.Transaction_Type);
                AccountType getAccountType = (AccountType)Enum.Parse(typeof(AccountType), getAcctType);
                DateTime getDate = DateTime.ParseExact(i.Transaction_Date, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                //Console.WriteLine(getDate + "\n" + i.Transaction_Date);

                Transactions transObj = new Transactions(getTransactionType, getAccountType, getDate, Convert.ToDouble(i.Amount));
                getTrans.Add(transObj);
            }

            return getTrans;

            
            
        }

        public List<Transactions> GetAllTransactions(int custID)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();

            var getAllTransQuery = bankDataContext.TransactionTables.Where(t => t.Customer_ID == custID);
            List<Transactions> getAllTrans = new List<Transactions>();

            foreach (var i in getAllTransQuery)
            {
                var getAcctType = bankDataContext.AccountTables.Single(a => a.Account_ID == i.Account_ID).Account_Type;
                

                TransactionType getTransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), i.Transaction_Type);
                AccountType getAccountType = (AccountType)Enum.Parse(typeof(AccountType), getAcctType);
                DateTime getDate = DateTime.ParseExact(i.Transaction_Date, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);


                Transactions getAllTransObj = new Transactions(getTransactionType, getAccountType,getDate, Convert.ToDouble(i.Amount));
                getAllTrans.Add(getAllTransObj);
            }
            return getAllTrans;
        }


        public double GetBalance(Transactions trans)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();
            Customer_Accounts_Table custAcctTable = new Customer_Accounts_Table();

            var balance = bankDataContext.Customer_Accounts_Tables.First(b => (b.Account_ID == trans.GetAccountID() && b.Customer_ID == trans.GetCustomerID())).Balance;

            return Convert.ToDouble(balance);


        }

        public double DepositAmount(Transactions trans)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();
            Customer_Accounts_Table custAcctTable = new Customer_Accounts_Table();

            if(bankDataContext.Customer_Accounts_Tables.Count(a => (a.Account_ID == trans.GetAccountID() && a.Customer_ID == trans.GetCustomerID())) < 1)
            {
                custAcctTable.Account_ID = trans.GetAccountID();
                custAcctTable.Customer_ID = trans.GetCustomerID();
                custAcctTable.Balance = trans.GetAmount();


                bankDataContext.Customer_Accounts_Tables.InsertOnSubmit(custAcctTable);
                bankDataContext.SubmitChanges();

                return Convert.ToDouble(custAcctTable.Balance);
            }
            else
            {
                var amtQuery = bankDataContext.TransactionTables.Where(t => (t.Account_ID == trans.GetAccountID() && t.Customer_ID == trans.GetCustomerID() && t.Transaction_Type == trans.GetTransactionType().ToString())).ToArray().Last().Amount;

                
                Customer_Accounts_Table myCust = bankDataContext.Customer_Accounts_Tables.Single(p => (p.Customer_ID == trans.GetCustomerID() && p.Account_ID == trans.GetAccountID()));
                myCust.Balance = myCust.Balance + amtQuery;
                

                bankDataContext.SubmitChanges();
                return Convert.ToDouble(myCust.Balance);
            }



            
            
        }

        public double WithdrawAmount(Transactions trans)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();
            Customer_Accounts_Table custAcctTable = new Customer_Accounts_Table();

            if (bankDataContext.Customer_Accounts_Tables.Count(a => (a.Account_ID == trans.GetAccountID() && a.Customer_ID == trans.GetCustomerID())) < 1)
            {
                custAcctTable.Account_ID = trans.GetAccountID();
                custAcctTable.Customer_ID = trans.GetCustomerID();
                custAcctTable.Balance = trans.GetAmount();


                bankDataContext.Customer_Accounts_Tables.InsertOnSubmit(custAcctTable);
                bankDataContext.SubmitChanges();

                return Convert.ToDouble(custAcctTable.Balance);
            }
            else
            {
                var amtQuery = bankDataContext.TransactionTables.Where(t => (t.Account_ID == trans.GetAccountID() && t.Customer_ID == trans.GetCustomerID() && t.Transaction_Type == trans.GetTransactionType().ToString())).ToArray().Last().Amount;


                Customer_Accounts_Table myCust = bankDataContext.Customer_Accounts_Tables.Single(p => (p.Customer_ID == trans.GetCustomerID() && p.Account_ID == trans.GetAccountID()));
                myCust.Balance = myCust.Balance - amtQuery;

                Console.WriteLine(myCust.Balance);
                bankDataContext.SubmitChanges();
                return Convert.ToDouble(myCust.Balance);
            }

        }

        public double DisplayBalance(int custID, int acctID)
        {
            BankDataContext bankDataContext = new BankDataContext();
            var bal = bankDataContext.Customer_Accounts_Tables.Single(b => (b.Account_ID == acctID && b.Customer_ID == custID)).Balance;
            return Convert.ToDouble(bal);
        }

    }
}
