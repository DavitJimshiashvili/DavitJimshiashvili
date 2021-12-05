using System;
using System.Collections.Generic;
using System.IO;

namespace GeographyNow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string path = @"C:\Cities.txt";       
            List<City> georgiaCities = new List<City>();
            List<City> franceCities = new List<City>();
            List<City> englandCities = new List<City>();
            List<City> allCities = new List<City>();
          
            
            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    string line =reader.ReadLine();
                    while (reader.Peek()>0)
                    {
                        string[] words = line.Split('|');
                        if (words[4] == "Georgia")
                        {
                            georgiaCities.Add(new City(words[0], double.Parse(words[1]), int.Parse(words[2]), Convert.ToBoolean(words[3]), words[4]));
                        }
                        if (words[4] == "France")
                        {
                            franceCities.Add(new City(words[0], double.Parse(words[1]), int.Parse(words[2]), Convert.ToBoolean(words[3]), words[4]));
                        }
                        if (words[4] == "England")
                        {
                            englandCities.Add(new City(words[0], double.Parse(words[1]), int.Parse(words[2]), Convert.ToBoolean(words[3]), words[4]));
                        }
                        line = reader.ReadLine();
                    }

                }

                for (int i = 0; i < 2; i++)
                {
                    allCities.Add(georgiaCities[i]);
                    allCities.Add(franceCities[i]);
                    allCities.Add(englandCities[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Country georgia = new Country(georgiaCities[0].BelongsCountry, georgiaCities);
            Country france = new Country(franceCities[0].BelongsCountry, franceCities);
            Country england = new Country(englandCities[0].BelongsCountry, englandCities);
            List < Country > allCountries= new List<Country>();
            allCountries.Add(georgia);
            allCountries.Add(france);
            allCountries.Add(england);

            Menu(allCountries, allCities);
            Console.WriteLine("Do you want to continue? enter - 1 ");
            int continueOption = int.Parse(Console.ReadLine());
            if(continueOption==1)
                Menu(allCountries, allCities);
            Console.ReadKey();
        }

        public static void Menu(List<Country> countriesList,List<City> allCitiesList)
        {
            Console.WriteLine("1.Search Country\n2.Search City.");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            foreach (var item in countriesList)
                            {
                                Console.WriteLine(item.CountryName);
                            }
                            Console.WriteLine("Enter country name:");
                            try
                            {
                                string chosenCountry = Console.ReadLine();
                                bool condition=false;
                                foreach (var item in countriesList)
                                {
                                    if (chosenCountry == item.CountryName)
                                    {
                                        condition = true;
                                        Console.WriteLine(item);
                                        break;
                                    }
                                    else
                                    {
                                        condition = false;
                                    }

                                }
                                if (!condition)
                                throw new FormatException("Wrong option");

                              
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                        }
                        break;
                    case 2:
                        {
                            foreach (var item in allCitiesList)
                            {
                                Console.WriteLine(item.CityName);
                            }
                            Console.WriteLine("Choose City name:");
                            try
                            {
                                string chosenCity = Console.ReadLine();
                                bool condition = false;
                                foreach (var item in allCitiesList)
                                {
                                    if (chosenCity == item.CityName)
                                    {
                                        condition = true;
                                        Console.WriteLine(item);
                                        break;
                                    }
                                    else
                                    {
                                        condition = false;
                                    }

                                }
                                if (!condition)
                                    throw new FormatException("Wrong city option");


                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    default:
                        throw new  Exception();
                        
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
