using System;

using BankingApplication_BO;

namespace BankingApplication_BLL
{
    public class SavingAccount_BLL
    {
        SavingAccount_BO savingAccount_BO = new SavingAccount_BO();

        

        public double Deposit(double amount)
        {
            savingAccount_BO.amount += amount;
            return GetBalance();
        }

        public double Withdraw(double amount)
        {
            savingAccount_BO.amount -= amount;
            return GetBalance();
        }
        public double GetBalance()
        {
            return savingAccount_BO.amount;
        }
    }
}
