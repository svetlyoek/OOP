namespace Vehicles.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Truck : Vehicle
    {
        private const double additionalFuelPerKm = 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm)
        {
        }

        public override string Drive(double distance)
        {
            if (this.FuelQuantity >= distance * (this.FuelConsumptionPerKm + additionalFuelPerKm))
            {
                this.FuelQuantity -= distance * (this.FuelConsumptionPerKm + additionalFuelPerKm);

                return $"Truck travelled {distance} km";
            }
            else
            {
                return $"Truck needs refueling";
            }

        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters * 0.95;
        }

        public override string ToString()
        {
            return $"Truck: " + base.ToString();
        }
    }
}
