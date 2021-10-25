using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLotLab
{
    class CarLot
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public int Count { get; set; } = 0;
        public CarLot()
        {
            Cars.Add(new Car("Ford", "Fusion", 2020, 20000));
            Cars.Add(new Car("Ford", "Focus", 2018, 15000));
            Cars.Add(new Car("Tesla", "Model X", 2020, 20000));

            Cars.Add(new UsedCar("Ford", "Fusion", 2010, 10000, 99999));
            Cars.Add(new UsedCar("Cadillac", "Escalade", 2005, 15000, 30156));
            Cars.Add(new UsedCar("Chevy", "Cruze", 2016, 25000, 199999));
        }
        public void AddCar(string Make, string Model, int Year, decimal Price)
        {
            Cars.Add(new Car(Make, Model, Year, Price));
        }
        public void AddUsedCar(string Make, string Model, int Year, decimal Price, double Mileage)
        {
            Cars.Add(new UsedCar(Make, Model, Year, Price, Mileage));
        }
        public void PrintCars()
        {
            for(int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{i+1}. " + Cars[i]);
            }
        }
        public void RemoveCar(string Make, string Model, int Year)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if(Cars[i].Make == Make && Cars[i].Model == Model && Cars[i].Year == Year)
                {
                    Cars.RemoveAt(i);
                    break;
                }
            }
        }
        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        /// <summary>
        /// Get an input as an integer
        /// </summary>
        /// <param name="prompt">
        /// The phrase that is output to the user
        /// </param>
        /// <returns></returns>
        public int GetInputInt(string prompt)
        {
            string response;
            int numResponse;
            while (true)
            {
                try
                {
                    response = GetInput(prompt);
                    numResponse = int.Parse(response);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer");
                    continue;
                }
            }
            return numResponse;
        }
        /// <summary>
        /// Displays menu and allows user to interact
        /// </summary>
        public void UserMenu()
        {

            Console.WriteLine("Welcome to the car lot");

            while (true)
            {
                PrintCars();
                Console.WriteLine($"{Cars.Count + 1}. Add a car");
                Console.WriteLine($"{Cars.Count + 2}. Add a used car");
                Console.WriteLine($"{Cars.Count + 3}. Quit");
                int choice = GetInputInt("Which car would you like?");
                if (choice > 0 && choice <= Cars.Count)
                {
                    Console.WriteLine(Cars[choice - 1]);
                    var currentCar = Cars[choice - 1];
                    string response = GetInput("Would you like to buy this car?").ToLower();
                    if (response == "y")
                    {
                        Console.WriteLine("Excellent! Our finance department will be in touch shortly");
                        RemoveCar(currentCar.Make, currentCar.Model, currentCar.Year);
                    }
                    else if (response == "n")
                    {
                        Console.WriteLine("Ok");
                    }
                    else
                    {
                        Console.WriteLine("Please enter only a y or an n");
                    }

                }
                else if (choice == Cars.Count + 1)
                {
                    Console.WriteLine("Please enter the information needed for the car:");
                    string make = GetInput("Make: ");
                    string model = GetInput("Model: ");
                    int year = GetInputInt("Year: ");
                    int price = GetInputInt("Price: ");
                    AddCar(make, model, year, price);
                }
                else if (choice == Cars.Count + 2)
                {
                    Console.WriteLine("Please enter the information needed for the car:");
                    string make = GetInput("Make: ");
                    string model = GetInput("Model: ");
                    int year = GetInputInt("Year: ");
                    int price = GetInputInt("Price: ");
                    int mileage = GetInputInt("Mileage: ");
                    AddUsedCar(make, model, year, price, mileage);
                }
                else if (choice == Cars.Count + 3)
                {
                    break;
                }
            }

        }


    }
}
