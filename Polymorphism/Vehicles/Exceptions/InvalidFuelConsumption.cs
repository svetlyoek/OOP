namespace Vehicles.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class InvalidFuelConsumption : Exception
    {
        private const string EXC_MESSAGE = "Fuel consumption cannot be negative!";

        public InvalidFuelConsumption()
            : base(EXC_MESSAGE)
        {
        }

        public InvalidFuelConsumption(string message)
            : base(message)
        {
        }
    }
}
