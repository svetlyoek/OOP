namespace FoodShortage.Runner
{
    using BirthdayCelebrations.Models;
    using FoodShortage.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Run
    {
        public void Starter()
        {
            var people = new List<Citizen>();
            var rebels = new List<Rebel>();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] lines = Console.ReadLine()
                    .Split()
                    .ToArray();
                try
                {
                    if (lines.Length == 3)
                    {
                        string name = lines[0];
                        int age = int.Parse(lines[1]);
                        string group = lines[2];

                        Rebel rebel = new Rebel(name, age, group);
                        rebels.Add(rebel);
                    }

                    else if (lines.Length == 4)
                    {
                        string name = lines[0];
                        int age = int.Parse(lines[1]);
                        string id = lines[2];
                        string birthdate = lines[3];

                        Citizen citizen = new Citizen(name, age, id, birthdate);
                        people.Add(citizen);
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            string nameToCheck = Console.ReadLine();

            while (nameToCheck != "End")
            {
                PeopleNameCheck(people, nameToCheck);

                RebelNameCheck(rebels, nameToCheck);

                nameToCheck = Console.ReadLine();
            }

            Console.WriteLine(people.Sum(p => p.Food) + rebels.Sum(p => p.Food));

        }

        private static void RebelNameCheck(List<Rebel> rebels, string nameToCheck)
        {
            if (rebels.FirstOrDefault(i => i.Name == nameToCheck) != null)
            {
                rebels.FirstOrDefault(x => x.Name == nameToCheck).BuyFood();
            }
        }

        private static void PeopleNameCheck(List<Citizen> people, string nameToCheck)
        {
            if (people.FirstOrDefault(i => i.Name == nameToCheck) != null)
            {
                people.FirstOrDefault(x => x.Name == nameToCheck).BuyFood();
            }
        }
    }
}


