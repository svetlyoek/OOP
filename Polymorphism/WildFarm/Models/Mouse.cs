namespace WildFarm.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Mouse : Mammal
    {
        private const double FOOD_MULTIPLIER = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override List<Type> PrefferedFood
            => new List<Type> { typeof(Vegetable), typeof(Fruit) };

        protected override double FoodMultiplier => FOOD_MULTIPLIER;
        public override string MakeSound()
        {
            return $"Squeak";
        }
    }
}
