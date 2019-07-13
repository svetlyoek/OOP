namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class InvalidWidthException : Exception
    {
        private const string EXC_MESSAGE = "Width cannot be negative!";
        public InvalidWidthException()
            : base(EXC_MESSAGE)
        {
        }

        public InvalidWidthException(string message)
            : base(message)
        {
        }
    }
}
