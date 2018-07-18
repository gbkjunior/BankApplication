using BankingApplication_BO;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BankingApplication_DAL
{
    public class Accounts_DAL
    {
        BankDataContext bankDataContext = new BankDataContext();

        AccountTable accountTableObject = new AccountTable();

        public void AddCustomerAccount(int custID, int acctID, double balance)
        {
            BankDataContext bankDataContext = new BankDataContext();
            Customer_Accounts_Table custAcctTable = new Customer_Accounts_Table();

            custAcctTable.Account_ID = acctID;
            custAcctTable.Customer_ID = custID;
            custAcctTable.Balance = Convert.ToDecimal(balance);

            bankDataContext.Customer_Accounts_Tables.InsertOnSubmit(custAcctTable);
            bankDataContext.SubmitChanges();

        }

        /// <summary>
        /// Method to get the account type from the DB
        /// </summary>
        /// <param name="acctID"></param>
        /// <returns>Accounts object</returns>
        public Accounts GetAccountType(int acctID)
        {
            var query = bankDataContext.AccountTables.FirstOrDefault(a => a.Account_ID == acctID);

            if(query == null)
            {
                //log exception, throw exception, let the user know 
                return null;
            }
            else
            {
                var accountType = query.Account_Type;
                AccountType newType = (AccountType)Enum.Parse(typeof(AccountType), accountType.ToString());
                Accounts objAccounts = new Accounts(newType);
                return objAccounts;
            }   
        }

        /// <summary>
        /// Method to get all the balances of a customer from the db
        /// </summary>
        /// <param name="custID"></param>
        /// <returns>List of transactions with accountType and balances</returns>
        public List<Transactions> GetAllBalances(int custID)
        {
            List<Transactions> allBalanceList = new List<Transactions>();
            BankDataContext bankDataContext = new BankDataContext();
            Customer_Accounts_Table transTable = new Customer_Accounts_Table();

            var allBalanceQuery = bankDataContext.Customer_Accounts_Tables.Where(trans => trans.Customer_ID == custID).Select(s => new { s.Account_ID, s.Balance }).ToList();

            foreach (var i in allBalanceQuery)
            {
                var getAcctType = bankDataContext.AccountTables.SingleOrDefault(a => a.Account_ID == i.Account_ID).Account_Type;
                AccountType getAccountType = (AccountType)Enum.Parse(typeof(AccountType), getAcctType);

                Transactions transObj = new Transactions(getAccountType, Convert.ToDouble(i.Balance));
                allBalanceList.Add(transObj);
            }

            return allBalanceList;
        }

        /// <summary>
        /// Method to get the current balance of a customer based on the accountType
        /// </summary>
        /// <param name="trans"></param>
        /// <returns>Current balance</returns>
        public double GetBalance(Transactions trans)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();
            Customer_Accounts_Table custAcctTable = new Customer_Accounts_Table();
            //var checkRecord = bankDataContext.TransactionTables.Where(c => (c.Account_ID == trans.GetAccountID() && c.Customer_ID == trans.GetCustomerID())).Any();
            var balance = bankDataContext.Customer_Accounts_Tables.FirstOrDefault(b => (b.Account_ID == trans.GetAccountID() && b.Customer_ID == trans.GetCustomerID()));
            if (balance == null)
            {
                return 0;
            }
            else
            {
                var checkBalance = bankDataContext.Customer_Accounts_Tables.Where(b => (b.Account_ID == trans.GetAccountID() && b.Customer_ID == trans.GetCustomerID())).Any();
                if (!checkBalance)
                    return 0;
                else
                    return Convert.ToDouble(balance.Balance);
            }

        }

        /// <summary>
        /// Method to bridge the Deposit Transaction and getting the current balance from the db. Uses the customer_accounts_table.
        /// </summary>
        /// <param name="trans"></param>
        /// <returns></returns>
        public double DepositAmount(Transactions trans)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();
            Customer_Accounts_Table custAcctTable = new Customer_Accounts_Table();

            if (bankDataContext.Customer_Accounts_Tables.Count(a => (a.Account_ID == trans.GetAccountID() && a.Customer_ID == trans.GetCustomerID())) < 1)
            {
                custAcctTable.Account_ID = trans.GetAccountID();
                custAcctTable.Customer_ID = trans.GetCustomerID();
                custAcctTable.Balance = Convert.ToDecimal(trans.GetAmount());

                bankDataContext.Customer_Accounts_Tables.InsertOnSubmit(custAcctTable);
                bankDataContext.SubmitChanges();

                return Convert.ToDouble(custAcctTable.Balance);
            }
            else
            {
                var amtQuery = bankDataContext.TransactionTables.Where(t => (t.Account_ID == trans.GetAccountID() && t.Customer_ID == trans.GetCustomerID() && t.Transaction_Type == trans.GetTransactionType().ToString())).ToArray().Last().Amount;

                custAcctTable = bankDataContext.Customer_Accounts_Tables.SingleOrDefault(p => (p.Customer_ID == trans.GetCustomerID() && p.Account_ID == trans.GetAccountID()));
                custAcctTable.Balance = custAcctTable.Balance + amtQuery;

                bankDataContext.SubmitChanges();

                return Convert.ToDouble(custAcctTable.Balance);
            }
        }

        /// <summary>
        /// Method to bridge the Withdraw Transaction and getting the current balance from the db. Uses the customer_accounts_table.
        /// </summary>
        /// <param name="trans"></param>
        /// <returns></returns>
        public double WithdrawAmount(Transactions trans)
        {
            BankDataContext bankDataContext = new BankDataContext();
            TransactionTable transTable = new TransactionTable();
            Customer_Accounts_Table custAcctTable = new Customer_Accounts_Table();

            if (bankDataContext.Customer_Accounts_Tables.Count(a => (a.Account_ID == trans.GetAccountID() && a.Customer_ID == trans.GetCustomerID())) < 1)
            {
                custAcctTable.Account_ID = trans.GetAccountID();
                custAcctTable.Customer_ID = trans.GetCustomerID();
                custAcctTable.Balance = Convert.ToDecimal(trans.GetAmount());


                bankDataContext.Customer_Accounts_Tables.InsertOnSubmit(custAcctTable);
                bankDataContext.SubmitChanges();

                return Convert.ToDouble(custAcctTable.Balance);
            }
            else
            {
                var amtQuery = bankDataContext.TransactionTables.Where(t => (t.Account_ID == trans.GetAccountID() && t.Customer_ID == trans.GetCustomerID() && t.Transaction_Type == trans.GetTransactionType().ToString())).ToArray().Last().Amount;

                Customer_Accounts_Table myCust = bankDataContext.Customer_Accounts_Tables.SingleOrDefault(p => (p.Customer_ID == trans.GetCustomerID() && p.Account_ID == trans.GetAccountID()));
                myCust.Balance = myCust.Balance - amtQuery;

                Console.WriteLine(myCust.Balance);
                bankDataContext.SubmitChanges();

                return Convert.ToDouble(myCust.Balance);
            }

        }
    }
}
