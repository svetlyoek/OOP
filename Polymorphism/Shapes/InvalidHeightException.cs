namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class InvalidHeightException : Exception
    {
        private const string EXC_MESSAGE = "Heght cannot be negative!";
        public InvalidHeightException()
            : base(EXC_MESSAGE)
        {
        }

        public InvalidHeightException(string message)
            : base(message)
        {
        }
    }
}
