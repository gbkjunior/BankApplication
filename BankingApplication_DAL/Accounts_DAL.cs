using BankingApplication_BO;
using System;
using System.Collections.Generic;

namespace BankingApplication_DAL
{
    public class Accounts_DAL
    {
        private List<Accounts> lstAccounts = new List<Accounts>();

        public Accounts_DAL()
        {
            lstAccounts.Add(new Accounts(100, AccountType.Checking)); 
            lstAccounts.Add(new Accounts(100, AccountType.Savings));
            lstAccounts.Add(new Accounts(100, AccountType.Loan));
        }

        public List<Accounts> GetAccounts()
        {
            return lstAccounts;
        }

        public void AddAccount(Accounts account)
        {
            lstAccounts.Add(account);
        } 


    }
}
