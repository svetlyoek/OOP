namespace Vehicles.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Vehicles.Models;

    public class Engine
    {
        public void Run()
        {
            Vehicle car = null;
            Vehicle truck = null;

            try
            {
                string[] carInfo = Console.ReadLine()
                  .Split()
                  .ToArray();

                double carFuelQuantity = double.Parse(carInfo[1]);
                double carFuelConsumption = double.Parse(carInfo[2]);
                car = new Car(carFuelQuantity, carFuelConsumption);

                string[] truckInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                double truckFuelQuantity = double.Parse(truckInfo[1]);
                double truckFuelConsumption = double.Parse(truckInfo[2]);
                truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            int commandCounter = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCounter; i++)
            {
                string[] line = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = line[0];
                string vehicleType = line[1];

                if (command == "Drive")
                {
                    PrintDriveCommand(car, truck, line, vehicleType);
                }

                else if (command == "Refuel")
                {
                    PrintRefuelCommand(car, truck, line, vehicleType);
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }

        private static void PrintRefuelCommand(Vehicle car, Vehicle truck, string[] line, string vehicleType)
        {
            double liters = double.Parse(line[2]);

            if (vehicleType == "Car")
            {
                car.Refuel(liters);
            }
            else if (vehicleType == "Truck")
            {
                truck.Refuel(liters);
            }
        }

        private static void PrintDriveCommand(Vehicle car, Vehicle truck, string[] line, string vehicleType)
        {
            double distance = double.Parse(line[2]);

            if (vehicleType == "Car")
            {
                Console.WriteLine(car.Drive(distance));
            }
            else if (vehicleType == "Truck")
            {
                Console.WriteLine(truck.Drive(distance));
            }
        }
    }
}
