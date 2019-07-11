namespace FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IByuer
    {
        int Food { get; }

        void BuyFood();
    }
}
