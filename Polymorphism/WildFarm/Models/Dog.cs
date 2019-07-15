namespace WildFarm.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Dog : Mammal
    {
        private const double FOOD_MULTIPLIER = 0.40;
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight,livingRegion)
        {
        }

        protected override List<Type> PrefferedFood
            => new List<Type> { typeof(Meat)};

        protected override double FoodMultiplier => FOOD_MULTIPLIER;

        public override string MakeSound()
        {
            return $"Woof!";
        }
    }
}
