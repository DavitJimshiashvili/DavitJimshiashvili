using System;
using System.Collections.Generic;
using System.Text;

namespace Day_17_1
{
    public class Debitban
    {

        double _percentForPeriod = 0.19;
        public void OpenDeposit(User x)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            x.CheckBalance();
            Console.WriteLine("Enter time period in months to open deposit ( + {0}% per month)",_percentForPeriod);
            try
            {
                 int month = int.Parse(Console.ReadLine());
                if (month > 0)
                {

                    double initialDeposit = x.Balance;
                    double finalAmount = initialDeposit *= Math.Pow((1 + _percentForPeriod / 100), month);
                    Console.WriteLine("Your balance in {0} months: {1}", month, finalAmount);
                }
                else
                throw new NegativeOrZeroValueException("Incorrect input, Number should be positive.");

            }
            catch (NegativeOrZeroValueException nz)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(nz.Message);
                OpenDeposit(x);
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                OpenDeposit(x);
            }


        }



    }
}
