namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class InvalidFoodException : Exception
    {
        private const string INVALID_FOOD = "Food cannot be null or empty!";
        public InvalidFoodException()
            : base(INVALID_FOOD)
        {
        }

        public InvalidFoodException(string message)
            : base(message)
        {
        }
    }
}
