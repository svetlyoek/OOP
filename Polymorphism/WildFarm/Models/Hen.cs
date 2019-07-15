namespace WildFarm.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Hen : Bird
    {
        private const double FOOD_MULTIPLIER = 0.35;
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
           
        }

        protected override List<Type> PrefferedFood
            => new List<Type> { typeof(Meat), typeof(Vegetable), typeof(Seeds), typeof(Fruit) };

        protected override double FoodMultiplier => FOOD_MULTIPLIER;
        public override string MakeSound()
        {
            return $"Cluck";
        }
    }
}
