using System;
using System.Linq;

namespace Customer_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string localPath1 = @"C:\Users\MURA\source\repos\DavitJimshiashvili\Homework_Day-25\Customer_Order\Customer_Order\Customers.txt";
            string localPath2 = @"C:\Users\MURA\source\repos\DavitJimshiashvili\Homework_Day-25\Customer_Order\Customer_Order\Orders.txt";
            CustomersReport customersReport = new CustomersReport(localPath1);
            var customers = customersReport.GetCustomers();
            OrdersReport ordersReport = new OrdersReport(localPath2);
            var orders = ordersReport.GetOrders().OrderBy(x=>x.CustomerID);// orders ordered by Customer ID
            Console.WriteLine("Report 1 : Customer - Orders count : \n");
            #region report 1
            var report1 = from o in orders
                          group o by new { o.CustomerID } into grp
                          select new
                          {
                              CustomerID = grp.Key.CustomerID,
                              OrderCount = grp.Count()
                          };

            foreach (var customer in report1)
            {
                Console.WriteLine($"CustomerID - {customer.CustomerID}, OrderCount - {customer.OrderCount}");
            }
            Console.WriteLine("==================================");
            #endregion
            Console.WriteLine("Report 2 : Customer - Sum amount of it's orders : \n");
            #region report 2
            var report2 = from o in orders
                          group o by new { o.CustomerID } into grp
                          select new
                          {
                              CustomerID = grp.Key.CustomerID,
                              SumAmount = grp.Sum(product => product.Price)
                          };

            foreach (var customer in report2)
            {
                Console.WriteLine($"CustomerID - {customer.CustomerID}, SumAmount - { customer.SumAmount}");
            }
            Console.WriteLine("==================================");
            #endregion
            Console.WriteLine("Report 3 : Customer - Customer's orders minimal price : \n");
            #region report 3
            var report3 = from o in orders
                          group o by new { o.CustomerID } into grp
                          select new
                          {
                              CustomerID = grp.Key.CustomerID,
                              MinAmount = grp.Min(product => product.Price)
                          };

            foreach (var customer in report3)
            {
                Console.WriteLine($"CustomerID - {customer.CustomerID}, MinAmount - { customer.MinAmount}");
            }
            Console.WriteLine("==================================");
            #endregion
            Console.WriteLine("Report 4 : Customer - Customer's orders count(where count is more than 1): \n");
            #region report 4
            var report4 = from o in orders
                          group o by new { o.CustomerID } into grp
                          where grp.Count()>1
                          select new
                          {
                              CustomerID = grp.Key.CustomerID,
                              OrderCount = grp.Count()
                          };

            foreach (var customer in report4)
            {
                Console.WriteLine($"CustomerID - {customer.CustomerID}, OrderCount - { customer.OrderCount}");
            }
            Console.WriteLine("==================================");
            #endregion
            Console.WriteLine("Report 5 : Customer - Customer's orders average(where orders avarage price is more than 10): \n");
            #region report 5
            var report5 = from o in orders
                          group o by new { o.CustomerID } into grp
                          where grp.Average(product => product.Price) > 10
                          select new
                          {
                              CustomerID = grp.Key.CustomerID,
                              AvgAmount = grp.Average(product => product.Price)
                          };

            foreach (var customer in report5)
            {
                Console.WriteLine($"CustomerID - {customer.CustomerID}, AvgAmount - { customer.AvgAmount}");
            }
            Console.WriteLine("==================================");
            #endregion
        }
    }
}
