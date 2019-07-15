namespace WildFarm.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WildFarm.Contracts;
    using WildFarm.Exceptions;

    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;

        }

        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        protected abstract double FoodMultiplier { get; }
        public abstract string MakeSound();

        protected abstract List<Type> PrefferedFood { get; }
        public void Feed(IFood food)
        {
            if (!this.PrefferedFood.Contains(food.GetType()))
            {
                throw new InvalidOperationException(string.Format(InvalidTypeOfFood.invalidFoodType, this.GetType().Name, food.GetType().Name));
            }

            this.Weight += food.Quantity * this.FoodMultiplier;
            this.FoodEaten += food.Quantity;

        }

        public override string ToString()
        {
            return $"{this.GetType().Name} ";
        }
    }
}
