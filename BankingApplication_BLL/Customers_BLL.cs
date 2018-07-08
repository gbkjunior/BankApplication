﻿using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;
using BankingApplication_DAL;

namespace BankingApplication_BLL
{
    public class Customers_BLL
    {

        Customers_DAL custObject = new Customers_DAL();

        public void AddNewCustomer(string custName, string custAddress, string custTelephone)
        {
            custObject.AddNewCustomer(new Customers(custName, custAddress, custTelephone));
        }
        
        public int GetCustomerID(string custName)
        {
            return custObject.GetCustomerIDAfterRegister(custName);
        }
        
        public string GetCustomerName(int custID)
        {
            return custObject.GetCustomerName(custID);
        }

        public bool validateCustomer(int custID)
        {
            return custObject.ValidateCustomer(custID);
        }
    }
}
