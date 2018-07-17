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
        /// <summary>
        /// Method to add a new customer into the db
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>New generated customerID</returns>
        public int AddNewCustomer1(Customers customer)
        {
            BankDataContext bankDataContext = new BankDataContext();
            CustomerTable custTable = new CustomerTable();

            bankDataContext.Connection.Open();

            custTable.Customer_Address = customer.GetCustomerAddress();
            custTable.Customer_Name = customer.GetCustomerName();
            custTable.Customer_Telephone = customer.GetCustomerTelephone();

            bankDataContext.CustomerTables.InsertOnSubmit(custTable);
            bankDataContext.SubmitChanges();
            // how linq to sql works in fetching the identity column
            return custTable.Customer_ID;

        }

        public int AddNewCustomer(Customers customer)
        {
            BankDataContext bankDataContext = new BankDataContext();
            CustomerTable custTable = new CustomerTable();

            bankDataContext.Connection.Open();

            custTable.Customer_Name = customer.GetCustomerName();
            custTable.Customer_Email = customer.GetCustomerEmail();
            custTable.Customer_Password = customer.GetCustomerPassword();
            custTable.Customer_DOB = customer.GetCustomerDOB();
            custTable.Customer_Telephone = customer.GetCustomerTelephone();
            custTable.Customer_Address = customer.GetCustomerAddress();

            bankDataContext.CustomerTables.InsertOnSubmit(custTable);
            bankDataContext.SubmitChanges();
            // how linq to sql works in fetching the identity column
            return custTable.Customer_ID;

        }

        /// <summary>
        /// Method to get the customer name from the db based on the customerID
        /// </summary>
        /// <param name="custID"></param>
        /// <returns>CustomerName</returns>
        public string GetCustomerName(int custID)
        {
            BankDataContext bankDataContext = new BankDataContext();
            CustomerTable custTable = new CustomerTable();

            var custNameQuery = bankDataContext.CustomerTables.SingleOrDefault(cust => cust.Customer_ID == custID).Customer_Name;

            if (custNameQuery == null)
                return "Customer Name not found";
            else
                return custNameQuery.ToString();
        }

        /// <summary>
        /// Method which checks the db and validates a customerID
        /// </summary>
        /// <param name="custID"></param>
        /// <returns>A bool value</returns>
        public bool ValidateCustomer(int custID, string password)
        {
            BankDataContext bankDataContext = new BankDataContext();
            CustomerTable custTable = new CustomerTable();

            var valIDQuery = bankDataContext.CustomerTables.Any(cust => (cust.Customer_ID == custID && cust.Customer_Password == password));

            if (!valIDQuery)
                return false;
            else
                return Convert.ToBoolean(valIDQuery);
        }
    }
}
