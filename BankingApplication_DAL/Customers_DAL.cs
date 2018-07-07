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
        BankDataContext bankDataContext = new BankDataContext();
        CustomerTable custTable = new CustomerTable();
        

        public void AddNewCustomer(Customers customer)
        {
            bankDataContext.Connection.Open();

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


            var custIDQuery = (from p in bankDataContext.CustomerTables
                       where p.Customer_Name == custName
                       select p.Customer_ID).Single();

            //Console.WriteLine(custIDQuery);
            return Convert.ToInt32(custIDQuery);               
        }

        public string GetCustomerName(int custID)
        {
            var custNameQuery = (from p in bankDataContext.CustomerTables
                                 where p.Customer_ID == custID
                                 select p.Customer_Name).Single();

            //Console.WriteLine(custNameQuery);
            return custNameQuery.ToString();
        }

        public bool ValidateCustomer(int custID)
        {

            var valIDQuery = (from p in bankDataContext.CustomerTables
                              where p.Customer_ID == custID
                              select p.Customer_ID).Single();
            //Console.WriteLine(valIDQuery);
            return Convert.ToBoolean(valIDQuery);
        }
    }
}
