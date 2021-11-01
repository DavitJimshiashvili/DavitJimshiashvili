using System;

namespace Day_05_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = filledArr();
            Console.Write("Enter number to check the array: ");
            int input = int.Parse(Console.ReadLine());

            bool valid=checkArr(array, input);


            if (valid)
            {
                Console.Write("Factorial of " + input + " is ");
                Console.WriteLine(factorial(input));
            }
            else Console.WriteLine("Number "+input+" was not found in the given array");




            Console.ReadKey();
        }

        static int[] filledArr()
        {
            Console.Write("Enter size of array: ");
            int arrSize = int.Parse(Console.ReadLine());
            int[] tempArr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write("Enter integer for index "+i+": ");
                tempArr[i] = int.Parse(Console.ReadLine());
            }

            return tempArr;

        }

        static bool checkArr(int[] arr, int number)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                    return true;
            }
            return false;
        }

        static int factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
      
    }
}
