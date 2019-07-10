namespace PersonInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private const int MIN_AGE = 0;

        private string name;
        private int age;
        private string id;
        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
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

        public string Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.invalidId);
                }

                this.id = value;
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
