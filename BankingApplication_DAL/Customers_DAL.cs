using BankingApplication_BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_DAL
{
    public class Customers_DAL
    {
        private static List<Customers> lstCustomers = new List<Customers>();
        int custID = 1;
        //public Customers_DAL()
        //{
        //    for(int i = 1; i < 6; i++)
        //    {
        //        lstCustomers.Add(new Customers(i));
        //    }
        //}

        public void AddNewCustomer(string custName, string custAddress, string custTelephone)
        {
            lstCustomers.Add(new Customers(custID, custName, custAddress, custTelephone));
            custID++;
        }

        public List<Customers> getLstCustomers()
        {
            return lstCustomers;
        }
    }
}
