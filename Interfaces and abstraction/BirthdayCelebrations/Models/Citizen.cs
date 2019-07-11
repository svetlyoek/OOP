namespace BirthdayCelebrations.Models
{
    using BirthdayCelebrations.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Citizen : Society, IBirthable, IName
    {
        private const int MIN_AGE = 0;

        private string name;
        private int age;
        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
            : base(id)
        {
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
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
            private set
            {
                if (value < MIN_AGE)
                {
                    throw new ArgumentException(ExceptionMessages.invalidAge);
                }

                this.age = value;
            }
        }
        public string Birthdate
        {
            get
            {
                return this.birthdate;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.invalidBirthdate);
                }

                this.birthdate = value;
            }
        }
    }
}
