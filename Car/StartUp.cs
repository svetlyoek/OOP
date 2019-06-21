using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Car car = new Car();

            car.Make = "VW";

            car.Model = "Golf";

            car.Year = 1998;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}



