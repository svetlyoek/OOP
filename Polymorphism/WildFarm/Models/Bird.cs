﻿namespace WildFarm.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $"[{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";

        }
    }
}
