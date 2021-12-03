using System;
using System.Collections.Generic;
using System.Text;

namespace Day_17_1
{
    public class Creditban
    {
        private int _limitedAmount = 1_000_000;
            
        public void takeCredit(User x)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter amount to take credit : ");
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (_limitedAmount - input >= 0 && input > 0)
                {
                    x.Balance += input;
                    _limitedAmount -= input;
                }
                else
                {
                    if (input <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new NegativeOrZeroValueException("Amount should be a positive number");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new CreditLimitException($"Credit has its limit - maxmum {_limitedAmount}$");
                    }
                }
            }
            catch(NegativeOrZeroValueException nz)
            {
                Console.WriteLine(nz.Message);
                takeCredit(x);
            }
            catch(CreditLimitException cl)
            {
                Console.WriteLine(cl.Message);
                takeCredit(x);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                takeCredit(x);
            }
        }
    }
}
