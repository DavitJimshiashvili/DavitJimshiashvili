using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Order
{
    public class Customer
    {
        public Customer(int customerID, string customerName)
        {
            CustomerID = customerID;
            CustomerName = customerName;
        }

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public override string ToString()
        {
            return $"Customer ID : {CustomerID}, Customer Name : {CustomerName}";
        }
    }
}
