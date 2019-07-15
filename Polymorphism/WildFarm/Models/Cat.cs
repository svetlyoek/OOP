namespace WildFarm.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Cat : Feline
    {
        private const double FOOD_MULTIPLIER = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
            this.Weight += this.FoodEaten * FOOD_MULTIPLIER;
        }


        protected override List<Type> PrefferedFood
            => new List<Type> { typeof(Meat), typeof(Vegetable) };

        protected override double FoodMultiplier => FOOD_MULTIPLIER;

        public override string MakeSound()
        {
            return $"Meow";
        }
    }
}
