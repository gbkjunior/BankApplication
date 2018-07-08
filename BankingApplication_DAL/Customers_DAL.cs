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

        

        public int AddNewCustomer(Customers customer)
        {

            BankDataContext bankDataContext = new BankDataContext();
            CustomerTable custTable = new CustomerTable();

            bankDataContext.Connection.Open();

            custTable.Customer_Address = customer.GetCustomerAddress();
            custTable.Customer_Name = customer.getCustomerName();
            custTable.Customer_Telephone = customer.GetCustomerTelephone();

            bankDataContext.CustomerTables.InsertOnSubmit(custTable);
            bankDataContext.SubmitChanges();
            // how linq to sql works in fetching the identity column

            return bankDataContext.CustomerTables.First(a => a.Customer_Name == custTable.Customer_Name).Customer_ID;
            
        }




        public string GetCustomerName(int custID)
        {

            BankDataContext bankDataContext = new BankDataContext();
            CustomerTable custTable = new CustomerTable();

            //use lambda expression

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

            //update
            var valIDQuery = (from p in bankDataContext.CustomerTables
                              where p.Customer_ID == custID
                              select p.Customer_ID).Any();
            //Console.WriteLine(valIDQuery);
            
             return Convert.ToBoolean(valIDQuery);
        }
    }
}
