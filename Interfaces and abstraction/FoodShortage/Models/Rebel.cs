namespace FoodShortage.Models
{
    using BirthdayCelebrations.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Rebel : Society, IByuer
    {
        private string group;
        private int food = 0;

        public Rebel(string name, int age, string group)
            : base(name, age)
        {
            this.Group = group;
            this.Food = 0;
        }

        public string Group
        {
            get
            {
                return this.group;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.invalidGroup);
                }

                this.group = value;
            }
        }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;

        }

    }
}
