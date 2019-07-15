namespace WildFarm.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Owl : Bird
    {
        private const double FOOD_MULTIPLIER = 0.25;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        protected override List<Type> PrefferedFood
            => new List<Type> { typeof(Meat) };

        protected override double FoodMultiplier => FOOD_MULTIPLIER;

        public override string MakeSound()
        {
            return $"Hoot Hoot";
        }
    }
}
