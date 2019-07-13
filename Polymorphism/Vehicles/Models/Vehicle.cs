namespace Vehicles.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Vehicles.Exceptions;

    public abstract class Vehicle
    {
        private const int MIN_FUEL_CONSUMPTION = 0;
        private const int MIN_FUEL_QUANTITY = 0;

        private double fuelQuantity;
        private double fuelConsumptionPerKm;

        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;

        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            protected set
            {
                if (value < MIN_FUEL_QUANTITY)
                {
                    throw new InvalidFuelQuantity();
                }

                this.fuelQuantity = value;
            }
        }

        public double FuelConsumptionPerKm
        {
            get
            {
                return this.fuelConsumptionPerKm;
            }
            protected set
            {
                if (value < MIN_FUEL_CONSUMPTION)
                {
                    throw new InvalidFuelConsumption();
                }

                this.fuelConsumptionPerKm = value;
            }
        }

        public abstract string Drive(double distance);

        public abstract void Refuel(double liters);

        public virtual  string ToString()
        {
            return $"{this.FuelQuantity:f2}";
        }

    }
}
