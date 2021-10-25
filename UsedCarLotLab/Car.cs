using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLotLab
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            this.Make = "";
            this.Model = "";
            this.Year = 0;
            this.Price = 0;
        }
        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }
        public override string ToString()
        {
            string output = $"{Make}\t" +
                $"{Model}\t" +
                $"{Year}\t" +
                $"{Price}\t";
            return output;
        }
    }
}
