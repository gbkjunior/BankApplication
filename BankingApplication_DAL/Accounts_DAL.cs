using BankingApplication_BO;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BankingApplication_DAL
{
    public class Accounts_DAL
    {
        private List<Accounts> lstAccounts = new List<Accounts>();

        public void AddAccounts(Accounts acct)
        {
            BankDataContext bankDataContext = new BankDataContext();

            AccountTable accountTableObject = new AccountTable();
            accountTableObject.Account_ID = acct.GetAccountID();
            accountTableObject.Account_Type = acct.GetAccountTypeForTable();

            bankDataContext.AccountTables.InsertOnSubmit(accountTableObject);
            bankDataContext.SubmitChanges();
        }

        public List<Accounts> GetAccounts()
        {
            return lstAccounts;
        } 


    }
}
