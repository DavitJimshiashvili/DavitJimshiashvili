using System;

namespace Day_05_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] resultArr=filledArray();
            int[] arr = minNmax(resultArr);

            Console.WriteLine("The minimum number in the array is "+arr[0]);
            Console.WriteLine("The maximum number in the array is "+ arr[1]);

            Console.ReadKey();
        }

        static int[] filledArray() {
            Console.Write("Enter size of array: ");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrSize];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter number for index " + i + ": ");
                array[i] = int.Parse(Console.ReadLine()); 
            }

            return array;
            
        }

        static int[] minNmax(int[] arr)
        {
            Array.Sort(arr);
            int[] temp = new int[2];
            temp[0] = arr[0];
            temp[1] = arr[arr.Length-1];
            return temp;
        }

    }
}
