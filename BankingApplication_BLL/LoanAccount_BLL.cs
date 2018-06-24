using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;
namespace BankingApplication_BLL
{
    public class LoanAccount_BLL
    {
        LoanAccount_BO loanAccount_BO = new LoanAccount_BO();

        public LoanAccount_BLL()
        {
            loanAccount_BO.amount = 100;
        }

        public double Deposit(double amount)
        {
            return loanAccount_BO.amount = loanAccount_BO.amount + amount;
        }

        public double Withdraw(double amount)
        {
            return loanAccount_BO.amount = loanAccount_BO.amount + amount;
        }
        public double GetBalance()
        {
            return loanAccount_BO.amount;
        }
    }
}
