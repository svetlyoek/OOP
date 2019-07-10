namespace BorderControl.Runner
{
    using BorderControl.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Run
    {
        public void Starter()
        {
            var inhabitans = new List<Society>();

            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] tokens = line
                    .Split()
                    .ToArray();

                try
                {
                    if (tokens.Length == 3)
                    {
                        string name = tokens[0];
                        int age = int.Parse(tokens[1]);
                        string id = tokens[2];

                        var citizen = new Citizen(name, age, id);
                        inhabitans.Add(citizen);
                    }

                    else if (tokens.Length == 2)
                    {

                        string name = tokens[0];
                        string id = tokens[1];

                        var robot = new Robot(name, id);
                        inhabitans.Add(robot);

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                line = Console.ReadLine();
            }

            string numberToCheck = Console.ReadLine();

            PrintDetained(inhabitans, numberToCheck);

        }

        private void PrintDetained(List<Society> societyList, string numberToCheck)
        {
            foreach (var inhabitant in societyList)
            {
                if (inhabitant.Id.EndsWith(numberToCheck))
                {
                    Console.WriteLine(inhabitant.Id);
                }
            }
        }

    }
}
