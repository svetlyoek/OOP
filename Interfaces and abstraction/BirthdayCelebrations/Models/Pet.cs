namespace BirthdayCelebrations.Models
{
    using BirthdayCelebrations.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Pet : IName, IBirthable
    {
        private string name;
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            this.Name = name;
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

        public string Birthdate
        {
            get
            {
                return this.birthdate;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.invalidBirthdate);
                }

                this.birthdate = value;
            }
        }
    }
}
