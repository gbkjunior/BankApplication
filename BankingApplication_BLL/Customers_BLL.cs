using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication_BO;
using BankingApplication_DAL;

namespace BankingApplication_BLL
{
    public class Customers_BLL
    {
        Customers_DAL custObject = new Customers_DAL();

        /// <summary>
        /// Method to add a new customer. Gets parameters from the user and calls the method to the DAL.
        /// </summary>
        /// <param name="custName"></param>
        /// <param name="custAddress"></param>
        /// <param name="custTelephone"></param>
        /// <returns>CustomerID</returns>
        public int AddNewCustomer(string custName, string email, string password, string dob, string custTelephone, string custAddress)
        {
            return custObject.AddNewCustomer(new Customers(custName, email, password, dob, custTelephone, custAddress));
        }
        /// <summary>
        /// Method to retrieve customer name based on his customerID
        /// </summary>
        /// <param name="custID"></param>
        /// <returns>CustomerName</returns>
        public string GetCustomerName(int custID)
        {
            return custObject.GetCustomerName(custID);
        }
        
        /// <summary>
        /// Method to validate a customer for login
        /// </summary>
        /// <param name="custID"></param>
        /// <returns>bool</returns>
        public bool validateCustomer(int custID, string password)
        {
            return custObject.ValidateCustomer(custID, password);
        }
    }
}
