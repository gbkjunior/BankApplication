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
        
        /// <summary>
        /// Method to Get the account type based on the account ID
        /// </summary>
        /// <param name="acctID"></param>
        /// <returns>Accounts object</returns>
        public Accounts GetAccountTypeByID(int acctID)
        {
            return accountsRepo.GetAccountType(acctID);
        }
    }
}
