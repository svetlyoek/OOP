namespace CustomException.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class InvalidPersonNameException : Exception
    {
        private const  string EXC_MESSAGE = "Name cannot constains digit or special symbol.";
        public InvalidPersonNameException()
            : base(EXC_MESSAGE)
        {
        }
        public InvalidPersonNameException(string message)
            : base(message)
        {
        }
    }
}
