using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_BO
{
    public class Customers
    {
        private int customerID;
        private string customerName;
        private string customerEmail;
        private string customerPassword;
        private string customerDOB;
        private string customerAddress;
        private string customerTelephone;
        
        /// <summary>
        /// Constructor to invoke while creation of a new customer
        /// </summary>
        /// <param name="custName"></param>
        /// <param name="custAddress"></param>
        /// <param name="custTelephone"></param>
        public Customers(string custName, string custAddress, string custTelephone)
        {
            this.customerName = custName;
            this.customerAddress = custAddress;
            this.customerTelephone = custTelephone;
        }

        public Customers(string custName, string email, string password, string dob , string custTelephone, string custAddress)
        {
            this.customerName = custName;
            this.customerEmail = email;
            this.customerPassword = password;
            this.customerDOB = dob;
            this.customerAddress = custAddress;
            this.customerTelephone = custTelephone;
        }

        /// <summary>
        /// Get method to retrive the customerID
        /// </summary>
        /// <returns>CustomerID</returns>
        public int GetCustomerID()
        {
            return this.customerID;
        }

        /// <summary>
        /// Get method to retrive the customer name
        /// </summary>
        /// <returns>CustomerName</returns>
        public string GetCustomerName()
        {
            return this.customerName;
        }

        public string GetCustomerEmail()
        {
            return this.customerEmail;
        }

        public string GetCustomerPassword()
        {
            return this.customerPassword;
        }

        public string GetCustomerDOB()
        {
            return this.customerDOB;
        }

        /// <summary>
        /// Get method to retrieve the customer address
        /// </summary>
        /// <returns>Customer Address</returns>
        public string GetCustomerAddress()
        {
            return this.customerAddress;
        }

        /// <summary>
        /// Get method to retrieve the customer telephone
        /// </summary>
        /// <returns>Customer Telephone</returns>
        public string GetCustomerTelephone()
        {
            return this.customerTelephone;
        }
    }
}
