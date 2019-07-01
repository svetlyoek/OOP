using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carFactory = new CarFactory();
            var engineFactory = new EngineFactory();
            var carSalesman = new CarSalesman(carFactory,engineFactory);

            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                carSalesman.AddEngine(engineInfo);
            }

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                carSalesman.AddCar(carInfo);
            }

            foreach (var car in carSalesman.GetCar())
            {
                Console.WriteLine(car.ToString());
            }
        }
    }

}
