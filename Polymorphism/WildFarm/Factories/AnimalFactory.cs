namespace WildFarm.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WildFarm.Models;

    public class AnimalFactory
    {
        public static Animal CreateAnimal(string[] animalInfo)
        {
            Animal animal = null;

            string type = animalInfo[0];
            string name = animalInfo[1];
            double weight = double.Parse(animalInfo[2]);

            switch (type)
            {
                case "Cat":
                    {
                        string livingRegion = animalInfo[3];
                        string breed = animalInfo[4];

                        animal = new Cat(name, weight, livingRegion, breed);
                    }
                    break;

                case "Tiger":
                    {
                        string livingRegion = animalInfo[3];
                        string breed = animalInfo[4];

                        animal = new Tiger(name, weight, livingRegion, breed);
                    }
                    break;

                case "Owl":
                    {
                        double wingSize = double.Parse(animalInfo[3]);

                        animal = new Owl(name, weight, wingSize);
                    }
                    break;

                case "Hen":
                    {
                        double wingSize = double.Parse(animalInfo[3]);

                        animal = new Hen(name, weight, wingSize);
                    }
                    break;

                case "Dog":
                    {
                        string livingRegion = animalInfo[3];

                        animal = new Dog(name, weight, livingRegion);
                    }
                    break;

                case "Mouse":
                    {
                        string livingRegion = animalInfo[3];

                        animal = new Mouse(name, weight, livingRegion);
                    }
                    break;

                default:
                    break;
            }

            return animal;
        }
    }
}

