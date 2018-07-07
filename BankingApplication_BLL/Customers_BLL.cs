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

        public void AddNewCustomer(string custName, string custAddress, string custTelephone)
        {
            custObject.AddNewCustomer(new Customers(custName, custAddress, custTelephone));
            //custObject.AddNewCustomer(custName,custAddress,custTelephone);
        }
        
        public int GetCustomerID(string custName)
        {
            int custID = custObject.GetCustomerIDAfterRegister(custName);

            return custID;
        }
        
        public string GetCustomerName(int custID)
        {
            string custName = "";
            for (int i = 0; i < custObject.getLstCustomers().Count; i++)
            {
                if (custObject.getLstCustomers()[i].getCustomerID() == custID)
                {
                    custName = custObject.getLstCustomers()[i].getCustomerName();
                }
            }
            return custName;
        }
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
