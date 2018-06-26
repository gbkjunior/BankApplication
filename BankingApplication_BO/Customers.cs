using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication_BO
{
    public class Customers
    {
        int customerID;

        public Customers(int custID)
        {
            this.customerID = custID;
        }

        public int getCustomerID()
        {
            return this.customerID;
        }
    }
}
