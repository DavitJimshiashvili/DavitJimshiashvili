using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Customer_Order
{
    public class CustomersReport 
    {
        private readonly string _FilePath;
        public CustomersReport( string path)
        {
            _FilePath = path;
          
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            ReportsReader reader = new ReportsReader(_FilePath);
            string[] linesArray=reader.ParseTextFile();
            for (int i=0; i<linesArray.Length;i++)
            {
                string[] words = linesArray[i].Split("|");
                customers.Add(new Customer(int.Parse(words[0]), words[1]));
            }

            return customers;
          
        }

    }
}
