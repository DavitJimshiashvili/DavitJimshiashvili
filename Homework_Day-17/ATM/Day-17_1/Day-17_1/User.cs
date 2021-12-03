using System;
using System.Collections.Generic;
using System.Text;

namespace Day_17_1
{
    public class User
    {
        public long UserId { get; set; }
        public short UserPin { get; set; }
        public double Balance { get; set; }

        public User(long id, short pin, double balance)
        {
            UserId = id;
            UserPin = pin;
            Balance = balance;
        }

        public void WithdrawCash()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            CheckBalance();
            Console.WriteLine("Enter amount to withdraw: ");
            try
            {
                double amount = double.Parse(Console.ReadLine());
                if (amount > 0 && Balance - amount >= 0)
                {
                    Balance -= amount;
                    CheckBalance();
                }
                else
                {
                    if (amount <= 0)
                        throw new NegativeOrZeroValueException("Amount should be positive.");
                    if (Balance - amount < 0)
                        throw new InsufficientBalanceException("Insufficient balance.");
                }
            }
            catch (NegativeOrZeroValueException nz)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(nz.Message);
                WithdrawCash();
            }
            catch (InsufficientBalanceException ib)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ib.Message);
                try
                {
                    Console.WriteLine("Do you want to take credit? (1/0)");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        Creditban credit = new Creditban();
                        credit.takeCredit(this);
                        WithdrawCash();
                    }
                    else
                    {
                        if (input == 0)
                        {
                            WithdrawCash();
                        }
                        else throw new Exception("Choose 1 if you agree, otherwise 0.");
                    }

                }
                catch (Exception myexception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(myexception.Message);
                    WithdrawCash();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DepositCash()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Deposit money: ");
            try
            {
                double amount = double.Parse(Console.ReadLine());
                if (amount > 0)
                {
                    Balance += amount;
                    CheckBalance();
                }
                if(amount <= 0)
                {
                    throw new NegativeOrZeroValueException("Amount should be a positive number");
                }
            }
            catch(NegativeOrZeroValueException nz)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(nz.Message);
                DepositCash();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                DepositCash();
            }
   
        }
        public void CheckBalance()
        {
            Console.WriteLine("Balance : {0}$", Balance);
        }

        public void UserInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"User:\nID : {UserId}\nPin : one-(2),three-(4)");
        }
    }
}
