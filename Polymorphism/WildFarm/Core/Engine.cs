namespace WildFarm.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WildFarm.Contracts;
    using WildFarm.Factories;
    using WildFarm.Factory;
    using WildFarm.Models;

    public class Engine
    {
        private readonly List<Animal> animals;

        public Engine()
        {
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] animalInfo = line
                    .Split()
                    .ToArray();

                string[] foodInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                Animal animal = AnimalFactory.CreateAnimal(animalInfo);
                Food food = FoodFactory.CreateFood(foodInfo);

                Console.WriteLine(animal.MakeSound());

                try
                {
                    animal.Feed(food);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                animals.Add(animal);

                line = Console.ReadLine();
            }

            PrintAnimals();

        }

        private void PrintAnimals()
        {
            foreach (var animal in this.animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
