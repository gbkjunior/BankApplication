using BankingApplication_BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_DAL
{
    public class Customers_DAL
    {
        private static List<Customers> lstCustomers = new List<Customers>();

        public Customers_DAL()
        {
            for(int i = 1; i < 6; i++)
            {
                lstCustomers.Add(new Customers(i));
            }
        }

        public List<Customers> getLstCustomers()
        {
            return lstCustomers;
        }
    }
}
