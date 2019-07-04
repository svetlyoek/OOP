using System;
using System.Linq;

namespace Animals
{
    public class Engine
    {
        public void Run()
        {
            while (true)
            {
                try
                {
                    string animalType = Console.ReadLine();

                    if (animalType == "Beast!")
                    {
                        break;
                    }

                    string[] animalInfo = Console.ReadLine()
                        .Split()
                        .ToArray();

                    string animalName = animalInfo[0];
                    int animalAge = int.Parse(animalInfo[1]);
                    string animalGender = animalInfo[2];

                    if (animalType == "Dog")
                    {
                        var dog = new Dog(animalName, animalAge, animalGender);
                        Console.WriteLine(dog);
                    }

                    else if (animalType == "Frog")
                    {
                        var frog = new Frog(animalName, animalAge, animalGender);
                        Console.WriteLine(frog);
                    }

                    else if (animalType == "Cat")
                    {
                        var cat = new Cat(animalName, animalAge, animalGender);
                        Console.WriteLine(cat);
                    }

                    else if (animalType == "Kitten")
                    {
                        var kitten = new Kitten(animalName, animalAge);
                        Console.WriteLine(kitten);
                    }

                    else if (animalType == "Tomcat")
                    {
                        var tomcat = new Tomcat(animalName, animalAge);
                        Console.WriteLine(tomcat);
                    }

                }
                catch (System.Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }
    }
}


