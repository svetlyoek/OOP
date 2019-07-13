namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class InvalidRadiusException : Exception
    {
        private const string EXC_MESSAGE = "Radius cannot be negative!";
        public InvalidRadiusException()
            : base(EXC_MESSAGE)
        {
        }
        public InvalidRadiusException(string message)
            : base(message)
        {
        }
    }
}
