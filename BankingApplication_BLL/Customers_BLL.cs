using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;

namespace BankingApplication_BLL
{
    public class Customers_BLL
    {
        List<Customers> lstCustomers = new List<Customers>();

        public Customers_BLL()
        {
            for(int i = 1; i < 6; i++)
            {
                lstCustomers.Add(new Customers(i));
            }
        }

        public bool validateCustomer(int custID)
        {
            bool flag = false;
            for(int i = 0; i < lstCustomers.Count; i++)
            {
                if(lstCustomers[i].getCustomerID() == custID)
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}
