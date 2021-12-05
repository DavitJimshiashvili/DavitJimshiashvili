using System;
using System.Collections.Generic;
using System.Text;

namespace GeographyNow
{
    public class City:GeographicEntity
    {
        public string CityName { get; set; }
        public double CityArea { get; set; }
        public int CityPopulation { get; set; }
        public bool IsCapital { get; set; }
        public string BelongsCountry { get; set; }
        public City(string cityName, double cityArea, int cityPopulation, bool isCapital, string belongsCountry)
        {
            CityName = cityName;
            CityArea = cityArea;
            CityPopulation = cityPopulation;
            IsCapital = isCapital;
            BelongsCountry = belongsCountry;
        }

        public override string ToString()
        {
            string iscapital = IsCapital ? "(Capital)" : "";
            return $"City: {CityName}{iscapital},Area: {CityArea},Population: {CityPopulation},Country: {BelongsCountry}";
        }
    }
}
