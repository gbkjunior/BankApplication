using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_BO
{
    public class Customers
    {
        int customerID;
        string customerName;
        string customerAddress;
        string customerTelephone;

        public Customers(int custID, string custName, string custAddress, string custTelephone)
        {
            this.customerID = custID;
            this.customerName = custName;
            this.customerAddress = custAddress;
            this.customerTelephone = custTelephone;
        }

        public Customers(string custName, string custAddress, string custTelephone)
        {
            this.customerName = custName;
            this.customerAddress = custAddress;
            this.customerTelephone = custTelephone;
        }

        public int getCustomerID()
        {
            return this.customerID;
        }

        public string getCustomerName()
        {
            return this.customerName;
        }

        public string GetCustomerAddress()
        {
            return this.customerAddress;
        }

        public string GetCustomerTelephone()
        {
            return this.customerTelephone;
        }
    }
}
