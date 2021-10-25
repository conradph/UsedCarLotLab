using System;
using System.Collections.Generic;
using System.Linq;

namespace UsedCarLotLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Used Car Emporium!");
            CarLot cars = new CarLot();
            cars.UserMenu();

        }
    }
}


