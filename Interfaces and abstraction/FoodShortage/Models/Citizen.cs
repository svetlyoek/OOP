namespace BirthdayCelebrations.Models
{
    using BirthdayCelebrations.Exceptions;
    using FoodShortage;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Citizen : Society, IByuer
    {
        private string id;
        private string birthdate;
        private int food;

        public Citizen(string name, int age, string id, string birthdate)
            : base(name, age)
        {
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = 0;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.invalidBirthdate);
                }

                this.birthdate = value;
            }
        }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
