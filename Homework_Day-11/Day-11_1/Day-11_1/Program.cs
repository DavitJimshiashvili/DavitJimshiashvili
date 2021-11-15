using System;
using System.Text;

namespace Day_11_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter base number: ");
            int baseNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter degree: ");
            int pow = int.Parse(Console.ReadLine());
            double result = Math.Pow(baseNumber, pow, out string status1);

            Console.WriteLine("{0}^{1}={2}",baseNumber,pow,result);
            Console.WriteLine("Status : {0}",status1);
            Console.WriteLine("---------------------");

            Console.Write("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            int minimum = Math.Minimum(firstNum , secondNum , out string status2);

            Console.WriteLine("minimum is {0}", minimum);
            Console.WriteLine("Status : {0}", status2);
            Console.WriteLine("---------------------");


            Console.Write("Enter first number: ");
            firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondNum = int.Parse(Console.ReadLine());
            int maximum = Math.Maximum(firstNum, secondNum, out string status3);

            Console.WriteLine("maximum is {0}", maximum);
            Console.WriteLine("Status : {0}", status3);






            Console.ReadKey();
        }
    }
}
