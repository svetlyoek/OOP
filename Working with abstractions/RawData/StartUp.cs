using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var carFactory = new CarFactory();

            for (int i = 0; i < lines; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                carFactory.Add(carInfo);

            }

            string command = Console.ReadLine();

            PrintOutput(command, carFactory);
        }

        private static void PrintOutput(string command, CarFactory carFactory)
        {
            if (command == "fragile")
            {
                List<string> fragile = carFactory.GetCar()
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else if (command == "flamable")
            {
                List<string> flamable = carFactory.GetCar()
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }

        }
    }
}
