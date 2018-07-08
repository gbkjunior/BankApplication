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
            accountTableObject.Account_Type = acct.GetAccountTypeForTable();

            bankDataContext.AccountTables.InsertOnSubmit(accountTableObject);
            bankDataContext.SubmitChanges();
        }

        public AccountType GetAccountType(int acctID)
        {
            var query = bankDataContext.AccountTables.First(a => a.Account_ID == acctID).Account_Type;
            //bool check = Enum.TryParse(query.ToString(), out AccountType acctTypeValue);
            
            //var getAcctTypeQuery = (from p in bankDataContext.AccountTables
            //                        where p.Account_ID == acctID
            //                        select p.Account_Type).Single();

            //enum
            AccountType newType = (AccountType)Enum.Parse(typeof(AccountType), query.ToString());

            return newType;
        }


        


    }
}
