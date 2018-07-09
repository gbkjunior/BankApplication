using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;
using BankingApplication_DAL;

namespace BankingApplication_BLL
{
    public class Accounts_BLL
    {
        Accounts_DAL accountsRepo = new Accounts_DAL();

        public Accounts_BLL() { }
        
        public AccountType GetAccountTypeByID(int acctID)
        {
            return accountsRepo.GetAccountType(acctID);
        }
    }
}
