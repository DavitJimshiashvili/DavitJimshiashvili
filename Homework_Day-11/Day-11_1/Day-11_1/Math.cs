using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11_1
{
    static class Math
    {
        public static double Pow(int number, int power, out string  status)
        {
            if (power < 0)
            {
                status = Statuses.PowMustBeaPositiveOrZero.ToString();
            }
            else
            {
                status = Statuses.Success.ToString();
                if (power == 0)
                    return 1;

                int result = 1;
                for (int i = 0; i < power; i++)
                {
                    result *= number;
                }
                return result;
            }
            return -1;
        }


        public static int Minimum(int firstNum, int secondNum,out string status)
        {
            if (firstNum == secondNum)
            {
                status = Statuses.NumbersAreEqual.ToString();
                return firstNum;
            }
            status = Statuses.FoundMinimum.ToString();
            return firstNum < secondNum ? firstNum : secondNum;
            
        }

        public static int Maximum(int firstNum, int secondNum, out string status)
        {
            if (firstNum == secondNum)
            {
                status = Statuses.NumbersAreEqual.ToString();
                return firstNum;
            }
            status = Statuses.FoundMaximum.ToString();
            return firstNum > secondNum ? firstNum : secondNum;

        }

    }

    public enum Statuses
    {
        PowMustBeaPositiveOrZero,
        Success,
        FoundMinimum,
        FoundMaximum,
        NumbersAreEqual
    }
}
