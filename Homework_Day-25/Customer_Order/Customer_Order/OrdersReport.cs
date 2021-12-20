using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Order
{
    public class OrdersReport
    {
        private readonly string _FilePath;
        public OrdersReport(string path)
        {
            _FilePath = path;
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            ReportsReader reader = new ReportsReader(_FilePath);
            string[] linesArray = reader.ParseTextFile();
            for (int i = 0; i < linesArray.Length; i++)
            {
                string[] words = linesArray[i].Split("|");
                orders.Add(new Order(int.Parse(words[0]), words[1],words[2],double.Parse(words[3]),int.Parse(words[4])));
            }

            return orders;

        }
    }
}
