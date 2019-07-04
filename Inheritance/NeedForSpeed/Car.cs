﻿namespace NeedForSpeed
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Car : Vehicle
    {
        private const double CarFuelConsumption = 3;
        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption
            => CarFuelConsumption;

    }
}
