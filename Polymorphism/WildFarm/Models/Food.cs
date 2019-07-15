namespace WildFarm.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WildFarm.Contracts;

    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; protected set; }
    }
}
