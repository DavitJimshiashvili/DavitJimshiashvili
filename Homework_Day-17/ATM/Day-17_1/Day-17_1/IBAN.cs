using System;
using System.Collections.Generic;
using System.Text;

namespace Day_17_1
{
    public class IBAN
    {
        public bool Verify(User x)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            int tries = 3;
            while (tries > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter pin: ");
                try
                {
                    short pincode = short.Parse(Console.ReadLine());
                    if (pincode == x.UserPin)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Access Granted");
                        return true;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Access Denied");
                        tries--;
                    }

                }
                catch (Exception ex)
                {
                    tries--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Your account was blocked.");
            return false;

        }

    }
}
