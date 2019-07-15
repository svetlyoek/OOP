namespace WildFarm.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Tiger : Feline
    {
        private const double FOOD_MULTIPLIER = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override List<Type> PrefferedFood
            => new List<Type> { typeof(Meat) };

        protected override double FoodMultiplier => FOOD_MULTIPLIER;
        public override string MakeSound()
        {
            return $"ROAR!!!";
        }
    }
}
