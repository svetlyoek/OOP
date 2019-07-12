namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine
    {
        public void Run()
        {
            try
            {
                Animal cat = new Cat("Pesho", "Whiskas");
                Animal dog = new Dog("Gosho", "Meat");

                Console.WriteLine(cat.ExplainSelf());
                Console.WriteLine(dog.ExplainSelf());
            }
            catch (InvalidNameException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (InvalidFoodException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
