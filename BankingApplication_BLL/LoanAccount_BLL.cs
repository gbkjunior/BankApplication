using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;
namespace BankingApplication_BLL
{
    public class LoanAccount_BLL
    {
        LoanAccount_BO loanAccount_BO = new LoanAccount_BO();

        

        public double Deposit(double amount)
        {
            loanAccount_BO.amount += amount;
            return GetBalance();
        }

        public double Withdraw(double amount)
        {
            loanAccount_BO.amount -= amount;
            return GetBalance();
        }
        public double GetBalance()
        {
            return loanAccount_BO.amount;
        }
    }
}
