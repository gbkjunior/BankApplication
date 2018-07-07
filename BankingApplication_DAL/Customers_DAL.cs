using BankingApplication_BO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.Linq;

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

        public void AddNewCustomer(Customers customer)
        {
            BankDataContext bankDataContext = new BankDataContext();
            bankDataContext.Connection.Open();

            CustomerTable custTable = new CustomerTable();

            custTable.Customer_Address = customer.GetCustomerAddress();
            custTable.Customer_Name = customer.getCustomerName();
            custTable.Customer_Telephone = customer.GetCustomerTelephone();

            bankDataContext.CustomerTables.InsertOnSubmit(custTable);
            bankDataContext.SubmitChanges();
        }

        public List<Customers> getLstCustomers()
        {
            return lstCustomers;
        }

        public int GetCustomerIDAfterRegister(string custName)
        {
            BankDataContext bankDataContext = new BankDataContext();
            CustomerTable custTable = new CustomerTable();

            var custIDQuery = (from p in bankDataContext.CustomerTables
                       where p.Customer_Name == custName
                       select p.Customer_ID).Single();

            Console.WriteLine(custIDQuery);
            return Convert.ToInt32(custIDQuery);               
        }
    }
}
