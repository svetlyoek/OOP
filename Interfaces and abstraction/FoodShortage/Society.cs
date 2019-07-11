namespace FoodShortage
{
    using BirthdayCelebrations.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public abstract class Society
    {
        private const int MIN_AGE = 0;

        private string name;
        private int age;

        public Society(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.invalidName);
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value < MIN_AGE)
                {
                    throw new ArgumentException(ExceptionMessages.invalidAge);
                }

                this.age = value;
            }
        }

    }
}
