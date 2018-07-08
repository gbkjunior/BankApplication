using BankingApplication_BO;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BankingApplication_DAL
{
    public class Accounts_DAL
    {


        public void AddAccounts(Accounts acct)
        {
            BankDataContext bankDataContext = new BankDataContext();

            AccountTable accountTableObject = new AccountTable();
            accountTableObject.Account_ID = acct.GetAccountID();
            accountTableObject.Account_Type = acct.GetAccountTypeForTable();

            bankDataContext.AccountTables.InsertOnSubmit(accountTableObject);
            bankDataContext.SubmitChanges();
        }

        public string GetAccountType(int acctID)
        {
            BankDataContext bankDataContext = new BankDataContext();

            AccountTable accountTableObject = new AccountTable();

            var getAcctTypeQuery = (from p in bankDataContext.AccountTables
                                    where p.Account_ID == acctID
                                    select p.Account_Type).Single();

            return getAcctTypeQuery.ToString();
        }


        


    }
}
