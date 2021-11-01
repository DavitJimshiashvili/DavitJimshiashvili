using System;

namespace Day_02_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your day of birth:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your month of birth:");
            string temp = Console.ReadLine();
            string month = temp.ToLower();
            string astroSign = "";
            if (month == "january")
            {
                if (day < 20)
                    astroSign = "Capricorn";
                else
                    astroSign = "Aquarius";
            }
            else if (month == "february")
            {
                if (day < 19)
                    astroSign = "Aquarius";
                else
                    astroSign = "Pisces";
            }
            else if (month == "march")
            {
                if (day < 21)
                    astroSign = "Pisces";
                else
                    astroSign = "Aries";
            }
            else if (month == "april")
            {
                if (day < 20)
                    astroSign = "Aries";
                else
                    astroSign = "Taurus";
            }
            else if (month == "may")
            {
                if (day < 21)
                    astroSign = "Taurus";
                else
                    astroSign = "Gemini";
            }
            else if (month == "june")
            {
                if (day < 21)
                    astroSign = "Gemini";
                else
                    astroSign = "Cancer";
            }
            else if (month == "july")
            {
                if (day < 23)
                    astroSign = "Cancer";
                else
                    astroSign = "Leo";
            }
            else if (month == "august")
            {
                if (day < 23)
                    astroSign = "Leo";
                else
                    astroSign = "Virgo";
            }
            else if (month == "september")
            {
                if (day < 23)
                    astroSign = "Virgo";
                else
                    astroSign = "Libra";
            }
            else if (month == "october")
            {
                if (day < 23)
                    astroSign = "Libra";
                else
                    astroSign = "Scorpio";
            }
            else if (month == "november")
            {
                if (day < 22)
                    astroSign = "Scorpio";
                else
                    astroSign = "Sagittarius";
            }
            else if (month == "december")
            {
                if (day < 22)
                    astroSign = "Sagittarius";
                else
                    astroSign = "Capricorn";
            }

            Console.WriteLine(day + " " + temp + " is " + astroSign);
        }
    }
}
