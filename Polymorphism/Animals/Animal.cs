namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public abstract class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
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
                    throw new InvalidNameException();
                }

                this.name = value;
            }
        }

        public string FavouriteFood
        {
            get
            {
                return this.favouriteFood;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidFoodException();
                }

                this.favouriteFood = value;
            }
        }
        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        }
    }
}
