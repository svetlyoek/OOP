namespace Vehicles.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class InvalidFuelQuantity : Exception
    {
        private const string EXC_MESSAGE = "Fuel quantity cannot be negative!";

        public InvalidFuelQuantity()
            : base(EXC_MESSAGE)
        {
        }

        public InvalidFuelQuantity(string message)
            : base(message)
        {
        }
    }
}
