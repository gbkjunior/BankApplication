﻿using BankingApplication_BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_BLL
{
    
    public class CheckingAccount_BLL : CheckingAccount_BO
    {
        
        CheckingAccount_BO checkingAccount_BO = new CheckingAccount_BO();

        public double Deposit(double amount)
        {
            checkingAccount_BO.amount += amount ;

            return GetBalance();
        }

        public double Withdraw(double amount)
        {
            checkingAccount_BO.amount -= amount;
            return GetBalance();
        }

        public double GetBalance()
        {
            return checkingAccount_BO.amount;
        }
    }
}
