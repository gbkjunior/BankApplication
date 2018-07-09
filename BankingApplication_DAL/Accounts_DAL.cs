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
