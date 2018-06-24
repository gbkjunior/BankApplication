using System;

using BankingApplication_BO;

namespace BankingApplication_BLL
{
    public class SavingAccount_BLL
    {
        SavingAccount_BO savingAccount_BO = new SavingAccount_BO();

        public SavingAccount_BLL()
        {
            savingAccount_BO.amount = 100;
        }

        public double Deposit(double amount)
        {
            return savingAccount_BO.amount = savingAccount_BO.amount + amount;
        }

        public double Withdraw(double amount)
        {
            return savingAccount_BO.amount = savingAccount_BO.amount - amount;
        }
        public double GetBalance()
        {
            return savingAccount_BO.amount;
        }
    }
}
