namespace WildFarm.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WildFarm.Models;

    public class FoodFactory
    {

        public static Food CreateFood(string[] foodInfo)
        {
            Food food = null;

            string type = foodInfo[0];
            int quantity = int.Parse(foodInfo[1]);

            switch (type)
            {
                case "Vegetable":
                    food = new Vegetable(quantity);
                    break;

                case "Fruit":
                    food = new Fruit(quantity);
                    break;

                case "Meat":
                    food = new Meat(quantity);
                    break;

                case "Seeds":
                    food = new Seeds(quantity);
                    break;

                default:
                    break;
            }

            return food;
        }
    }
}
