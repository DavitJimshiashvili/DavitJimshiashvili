using System;
using System.Collections.Generic;
using System.Text;

namespace GeographyNow
{
    public class Country:GeographicEntity
    {

        public double CountryArea { get; set; }
        public int CountryPopulation { get; set; }
        public string CountryName { get; set; }
        public List<City> CountryCities { get; set; }
        public Country(string thisCountryName, List<City> thisCountryCities)
        {
            CountryName = thisCountryName;
            CountryCities = thisCountryCities;
            CalculateArea();
            CalculatePopulation();

        }

        public void CalculateArea()
        {
            CountryArea = CountryCities[0].CityArea + CountryCities[1].CityArea;
        }
        public void CalculatePopulation()
        {
            CountryPopulation = CountryCities[0].CityPopulation + CountryCities[1].CityPopulation;
        }
        public override string ToString()
        {
            return $"Country: {CountryName},Area: {CountryArea},Population: {CountryPopulation},Cities: \n{CountryCities[0]}\n{CountryCities[1]}";
        }
    }
}
