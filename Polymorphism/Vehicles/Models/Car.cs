namespace Vehicles.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Car : Vehicle
    {
        private const double additionalFuelPerKM = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm)
        {
        }

        public override string Drive(double distance)
        {
            if (this.FuelQuantity >= distance * (this.FuelConsumptionPerKm + additionalFuelPerKM))
            {
                this.FuelQuantity -= distance * (this.FuelConsumptionPerKm + additionalFuelPerKM);

                return $"Car travelled {distance} km";
            }
            else
            {
                return $"Car needs refueling";
            }
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"Car: " + base.ToString();
        }
    }
}
