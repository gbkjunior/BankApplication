using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;
using BankingApplication_DAL;

namespace BankingApplication_BLL
{
    public class Customers_BLL
    {
        List<Customers> lstCustomers = new List<Customers>();
        Customers_DAL custObject = new Customers_DAL();

        
        

      
        public bool validateCustomer(int custID)
        {
            bool flag = false;
            for(int i = 0; i < custObject.getLstCustomers().Count; i++)
            {
                if(custObject.getLstCustomers()[i].getCustomerID() == custID)
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}
