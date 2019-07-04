﻿namespace NeedForSpeed
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual double FuelConsumption
            => DefaultFuelConsumption;


        public double Fuel { get; private set; }

        public int HorsePower { get; private set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= this.FuelConsumption * kilometers;
        }
    }
}
