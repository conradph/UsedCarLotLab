using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLotLab
{
    class UsedCar : Car
    {
        public double Mileage { get; set; }
        public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage)
            : base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }
        public override string ToString()
        {
            string output = base.ToString();
            output += $"(Used) {Mileage} miles";
            return output;
        }
    }
}
