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

        public void AddAccounts(Accounts acct)
        {
            accountTableObject.Account_ID = acct.GetAccountID();
            accountTableObject.Account_Type = acct.GetAccountType().ToString();

            bankDataContext.AccountTables.InsertOnSubmit(accountTableObject);
            bankDataContext.SubmitChanges();
        }

        public AccountType GetAccountType(int acctID)
        {
            var query = bankDataContext.AccountTables.FirstOrDefault(a => a.Account_ID == acctID);

            if(query == null)
            {
                //log exception, throw exception, let the user know 
                return 0;
            }
            else
            {
                var accountType = query.Account_Type;
                AccountType newType = (AccountType)Enum.Parse(typeof(AccountType), accountType.ToString());

                return newType;
            }   
        }
    }
}
