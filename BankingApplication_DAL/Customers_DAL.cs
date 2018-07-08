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

        

        public void AddNewCustomer(Customers customer)
        {

            BankDataContext bankDataContext = new BankDataContext();
            CustomerTable custTable = new CustomerTable();

            bankDataContext.Connection.Open();

            custTable.Customer_Address = customer.GetCustomerAddress();
            custTable.Customer_Name = customer.getCustomerName();
            custTable.Customer_Telephone = customer.GetCustomerTelephone();

            bankDataContext.CustomerTables.InsertOnSubmit(custTable);
            bankDataContext.SubmitChanges();
        }

        

        public int GetCustomerIDAfterRegister(string custName)
        {


            BankDataContext bankDataContext = new BankDataContext();
            CustomerTable custTable = new CustomerTable();

            var custIDQuery = (from p in bankDataContext.CustomerTables
                       where p.Customer_Name == custName
                       select p.Customer_ID).Single();

            //Console.WriteLine(custIDQuery);
            return Convert.ToInt32(custIDQuery);               
        }

        public string GetCustomerName(int custID)
        {

            BankDataContext bankDataContext = new BankDataContext();
            CustomerTable custTable = new CustomerTable();

            var custNameQuery = (from p in bankDataContext.CustomerTables
                                 where p.Customer_ID == custID
                                 select p.Customer_Name).Single();

            //Console.WriteLine(custNameQuery);
            return custNameQuery.ToString();
        }

        public bool ValidateCustomer(int custID)
        {

            BankDataContext bankDataContext = new BankDataContext();
            CustomerTable custTable = new CustomerTable();

            var valIDQuery = (from p in bankDataContext.CustomerTables
                              where p.Customer_ID == custID
                              select p.Customer_ID).Any();
            //Console.WriteLine(valIDQuery);
            
             return Convert.ToBoolean(valIDQuery);
        }
    }
}
