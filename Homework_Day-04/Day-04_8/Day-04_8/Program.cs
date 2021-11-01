using System;

namespace Day_04_8
{
    class Program
    {
        static void Main(string[] args)
        {



            int[][,] Jarray1 = new int[][,]
            {
               new int[,] { { 0, 1, 1, 1, 1, 1, 1, 1 }, { 0, 0, 1, 1, 1, 1, 1, 1 }, { 0, 0, 0, 1, 1, 1, 1, 1 }, { 0, 0, 0, 0, 1, 1, 1, 1 },
               { 0, 0, 0, 0, 0, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0, 1 } , { 0, 0, 0, 0, 0, 0, 0, 0 } }
            };


            Console.WriteLine("First matrix: ");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(Jarray1[0][i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            for (int i = 0; i < 4; i++)
            {
                for (int j = i; j < 7 - i; j++)
                {

                    int temp = Jarray1[0][i, j];
                    Jarray1[0][i, j] = Jarray1[0][7 - j, i];
                    Jarray1[0][7 - j, i] = Jarray1[0][7 - i, 7 - j];
                    Jarray1[0][7 - i, 7 - j] = Jarray1[0][j, 7 - i];
                    Jarray1[0][j, 7 - i] = temp;
                }
            }

            Console.WriteLine("Rotated matrix :");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(Jarray1[0][i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}