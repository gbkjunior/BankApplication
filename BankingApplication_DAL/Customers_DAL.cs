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
            return custTable.Customer_ID;

        }

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

        public bool ValidateCustomer(int custID)
        {
            BankDataContext bankDataContext = new BankDataContext();
            CustomerTable custTable = new CustomerTable();

            var valIDQuery = bankDataContext.CustomerTables.Any(cust => cust.Customer_ID == custID);

            if (!valIDQuery)
                return false;
            else
                return Convert.ToBoolean(valIDQuery);
        }
    }
}
