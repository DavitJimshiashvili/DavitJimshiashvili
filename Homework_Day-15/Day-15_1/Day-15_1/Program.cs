using System;

namespace Day_15_1
{
    class Program
    {
        static void Main(string[] args)
        {

            IntMathOperation<int> integer = new IntMathOperation<int>();
            int integer1 = 12;
            int integer2 = 9;
            Console.WriteLine($"Integers addition: {integer1} + {integer2} = {integer.Addition(integer1,integer2)}");
            Console.WriteLine($"Integers subtraction: {integer1} - {integer2} = {integer.Subtraction(integer1,integer2)}");
            Console.WriteLine($"Integers multiplication: {integer1} * {integer2} = {integer.Multiplication(integer1,integer2)}");
     


            VectorMathOperation<Vector> vector = new VectorMathOperation<Vector>();
            Vector vec1 = new Vector(2, 4);
            Vector vec2 = new Vector(3, 8);
            Console.WriteLine($"Vectors addition: {vec1} + {vec2} : { vector.Addition(vec1, vec2)}");
            Console.WriteLine($"Vectors subtraction: {vec1} - {vec2} : { vector.Subtraction(vec1, vec2)}");
            Console.WriteLine($"Vectors multiplication: {vec1} * {vec2} : { vector.Multiplication(vec1, vec2)} _ where ordinate is scalar.");


            MatrixMathOperation<Matrix> matrix = new MatrixMathOperation<Matrix>();
            Matrix firstMatrix = new Matrix(new int[,] { { 1, 2 }, { 3, 7 } });
            Matrix secondMatrix = new Matrix(new int[,] { { 7, 3 }, { 2, 3 } });
            Console.WriteLine($"Matrices addition:\n{firstMatrix} \n  +  \n{secondMatrix}\n  =  \n{ matrix.Addition(firstMatrix, secondMatrix)}");
            Console.WriteLine($"Matrices subtraction:\n{firstMatrix} \n  -  \n{secondMatrix}\n  =  \n{ matrix.Subtraction(firstMatrix, secondMatrix)}");
            Console.WriteLine($"Matrices multiplication:\n{firstMatrix} \n  *  \n{secondMatrix}\n  =  \n{ matrix.Multiplication(firstMatrix, secondMatrix)}");
           

            //Matrix matriecsAddition = firstMatrix + secondMatrix;
            //Matrix matricesSubtraction = firstMatrix - secondMatrix;
            //Matrix matricesMultiplication = firstMatrix * secondMatrix;
            //Console.WriteLine(matriecsAddition.ToString()); 
        }
    }
}
