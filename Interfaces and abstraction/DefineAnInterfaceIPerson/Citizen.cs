namespace PersonInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Citizen : IPerson
    {
        private const int MIN_AGE = 0;

        private string name;
        private int age;

        public Citizen(string name, int age)
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
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.invaliName);
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
            private set
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

