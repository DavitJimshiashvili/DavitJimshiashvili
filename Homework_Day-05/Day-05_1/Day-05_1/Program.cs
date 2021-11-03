using System;

namespace Day_05_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1, 3, 4, 15, 13, 23, 98 };
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number at index "+ index+" in the array is ");
            Console.WriteLine(arrElement(array, index));

            Console.ReadLine();
        }

        static int arrElement(int[] arr,int index) 
        {
            return arr[index];
        }

    }
}
