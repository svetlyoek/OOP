namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    public class InvalidNameException : Exception
    {
        private const string INVALID_NAME = "Name cannot be null or empty!";

        public InvalidNameException()
            : base(INVALID_NAME)
        {
        }

        public InvalidNameException(string message)
            : base(message)
        {
        }
    }
}
