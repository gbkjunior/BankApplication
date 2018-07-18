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

            string insertStatement = "Insert into Customer_Accounts_Table(CustomerID, AccountID, Balance) values('',''+acctID,''+balance)";
            bankDataContext.ExecuteQuery<Customer_Accounts_Table>(insertStatement);
            //bankDataContext.Customer_Accounts_Tables.InsertOnSubmit(custAcctTable);
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
    }
}
