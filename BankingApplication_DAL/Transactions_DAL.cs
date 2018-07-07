using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;
using System.Linq;

namespace BankingApplication_DAL
{
    public class Transactions_DAL
    {
        private static List<Transactions> lstTransactions = new List<Transactions>();

        

        public void AddTransaction(double amount, double balance, AccountType acctType)
        {
            lstTransactions.Add(new Transactions(TransactionType.Deposit, acctType, DateTime.Now, amount, balance));
            Console.WriteLine(lstTransactions.Count);
        }

        public void AddTransaction(Transactions trans)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();

            transTable.Transaction_Type = trans.GetTransactionType();
            transTable.Account_ID = trans.GetAccountID();
            transTable.Customer_ID = trans.GetCustomerID();
            transTable.Transaction_Date = trans.getDate();
            transTable.Amount = trans.getAmount();

            //transTable.Customer_Accounts_Table.Account_ID = trans.GetAccountID();
            //transTable.Customer_Accounts_Table.Customer_ID = trans.GetCustomerID();
            //transTable.Customer_Accounts_Table.Balance = trans.getAmount();


            
            bankDataContext.TransactionTables.InsertOnSubmit(transTable);
            
            bankDataContext.SubmitChanges();

        }
        
        public List<Transactions> GetListTransactions()
        {
            return lstTransactions;
        }

        

        public double GetBalance(Transactions trans)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();
            Customer_Accounts_Table custAcctTable = new Customer_Accounts_Table();

            var amtQuery = (from p in bankDataContext.TransactionTables
                            where p.Customer_ID == trans.GetCustomerID() && p.Account_ID == trans.GetAccountID()
                            select p.Amount).Single();

            custAcctTable.Account_ID = trans.GetAccountID();
            custAcctTable.Customer_ID = trans.GetCustomerID();
            custAcctTable.Balance = amtQuery;

            
            bankDataContext.SubmitChanges();

            return Convert.ToDouble(amtQuery);

            
        }

        public double DepositAmount(int custID, int acctID, double amt)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();
            Customer_Accounts_Table custAcctTable = new Customer_Accounts_Table();

            custAcctTable.Account_ID = acctID;
            custAcctTable.Customer_ID = custID;
            custAcctTable.Balance = Convert.ToDecimal(amt);

            
            bankDataContext.SubmitChanges();

            var amtQuery = (from p in bankDataContext.TransactionTables
                            where p.Customer_ID == custID && p.Account_ID == acctID
                            select p.Amount).Single();
            amtQuery = amtQuery + Convert.ToDecimal(amt);

            return Convert.ToDouble(amtQuery);
        }

        public double WithdrawAmount(int custID, int acctID, double amt)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();

            var amtQuery = (from p in bankDataContext.TransactionTables
                            where p.Customer_ID == custID && p.Account_ID == acctID
                            select p.Amount).Single();
            amtQuery = amtQuery - Convert.ToDecimal(amt);

            return Convert.ToDouble(amtQuery);
        }

        public void GetTransactionsByAcctID(int custID, int acctID)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();
            AccountTable acctTable = new AccountTable();

            var getTransQuery = (from p in bankDataContext.TransactionTables
                                 where p.Customer_ID == custID && p.Account_ID == acctID
                                 select p);
            
             
            foreach(var i in getTransQuery)
            {
                var getAcctType = (from p in bankDataContext.AccountTables
                                   where p.Account_ID == i.Account_ID
                                   select p.Account_Type).Single();

                Console.WriteLine("Account Type: {0}", getAcctType);
                Console.WriteLine("Transaction Type: {0}", i.Transaction_Type);
                Console.WriteLine("Transaction Date: {0}", i.Transaction_Date);
                Console.WriteLine("Amount: {0}", i.Amount);
                
                Console.WriteLine();
            }
        }

        public void GetAllTransactions(int custID)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();

            var getAllTransQuery = (from p in bankDataContext.TransactionTables
                                 where p.Customer_ID == custID
                                 select p);

            foreach (var i in getAllTransQuery)
            {
                var getAcctType = (from p in bankDataContext.AccountTables
                                   where p.Account_ID == i.Account_ID
                                   select p.Account_Type).Single();

                Console.WriteLine("Account Type: {0}", getAcctType);
                Console.WriteLine("Transaction Type: {0}", i.Transaction_Type);
                Console.WriteLine("Transaction Date: {0}", i.Transaction_Date);
                Console.WriteLine("Amount: {0}", i.Amount);

                Console.WriteLine();
            }
        }
    
    }
}
