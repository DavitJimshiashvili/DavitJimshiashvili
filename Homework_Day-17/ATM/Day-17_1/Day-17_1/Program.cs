using System;

namespace Day_17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IBAN account = new IBAN();
            Creditban creditbank = new Creditban();
            Debitban debit = new Debitban();
            User user = new User(24442444, 2444, 500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------ATM-------------\n");
            Console.WriteLine("Verify for access ");
            user.UserInfo();
            bool access = account.Verify(user);
            int closeOption = 0;
            if (access)
            {
                while (closeOption == 0)
                {
                    Menu();
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            user.CheckBalance();
                            break;
                        case 2:
                            user.WithdrawCash();
                            break;
                        case 3:
                            user.DepositCash();
                            break;
                        case 4:
                            creditbank.takeCredit(user);
                            break;
                        case 5:
                            debit.OpenDeposit(user);
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Do you want to close? 1/0");
                    closeOption = int.Parse(Console.ReadLine());

                }

            }


            //Exception ex = new Exception("first", new Exception("second", new Exception("third")));
            //ExceptionHelperMethods exh = new ExceptionHelperMethods();
            //Console.WriteLine(exh.GetLastInnerExMessage(ex));
            //Console.WriteLine(exh.GetAllInnerExMessageTogether(ex));

            Console.ReadKey();
        }
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Options: ");
            Console.WriteLine("1.Check balance");
            Console.WriteLine("2.Withdraw Cash");
            Console.WriteLine("3.Deposit Cash");
            Console.WriteLine("4.Take credit");
            Console.WriteLine("5.Open deposit");

        }
    }
}
