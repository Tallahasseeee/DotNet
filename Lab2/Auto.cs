using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2DotNet
{
    public class Auto
    {
        public string Brand;
        public string Model;
        public int Cost;
        public string Type;
        public int RentalPrice;
        public int YearOfProduction;
        public int RentalPeriod;

        public Auto() { }
        public Auto(string brand, string model, int cost, string type, int yearOfProduction, int rentalPeriod)
        {
            Brand = brand;
            Model = model;
            Cost = cost;
            Type = type;
            YearOfProduction = yearOfProduction;
            RentalPeriod = rentalPeriod;
            RentalPrice = (int)(((float)Cost / 100f) * (1f - (float)rentalPeriod / 5000f) * (((float)YearOfProduction - 1970f) / 53f));
        }
    }
}

