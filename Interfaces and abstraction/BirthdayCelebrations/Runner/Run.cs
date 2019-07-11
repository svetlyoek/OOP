namespace BirthdayCelebrations.Runner
{
    using BirthdayCelebrations.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Run
    {
        public void Starter()
        {
            List<IBirthable> inhabitans = new List<IBirthable>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input
                    .Split()
                    .ToArray();

                try
                {
                    if (tokens.Contains("Citizen"))
                    {
                        string name = tokens[1];
                        int age = int.Parse(tokens[2]);
                        string id = tokens[3];
                        string birthdate = tokens[4];

                        var citizen = new Citizen(name, age, id, birthdate);
                        inhabitans.Add(citizen);
                    }

                    else if (tokens.Contains("Pet"))
                    {
                        string name = tokens[1];
                        string birthdate = tokens[2];

                        var pet = new Pet(name, birthdate);
                        inhabitans.Add(pet);
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }


                input = Console.ReadLine();
            }

            string yearToCheck = Console.ReadLine();

            PrintBirthdate(yearToCheck, inhabitans);

        }

        private void PrintBirthdate(string yearsToCheck, List<IBirthable> inhabitans)
        {
            foreach (var inhabitant in inhabitans)
            {
                if (inhabitant.Birthdate.EndsWith(yearsToCheck))
                {
                    Console.WriteLine(inhabitant.Birthdate);
                }
            }
        }
    }
}
