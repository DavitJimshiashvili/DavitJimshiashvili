using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Order
{
    public class Order
    {
        public Order(int orderID, string date, string product, double price, int customerID)
        {
            OrderID = orderID;
            Date = date;
            Product = product;
            Price = price;
            CustomerID = customerID;
        }

        public int OrderID { get; set; }
        public string Date { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int CustomerID { get; set; }


        public override string ToString()
        {
            return $"Order ID : {OrderID}, Date : {Date}, Product : {Product}, Price : {Price}, Customer ID : { CustomerID}";
        }

    }
}
