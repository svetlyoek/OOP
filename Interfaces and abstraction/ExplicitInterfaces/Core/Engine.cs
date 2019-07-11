namespace ExplicitInterfaces.Core
{
    using ExplicitInterfaces.Contracts;
    using ExplicitInterfaces.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Engine
    {
        public void Run()
        {
            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] tokens = line
                    .Split()
                    .ToArray();

                string name = tokens[0];
                string country = tokens[1];
                int age = int.Parse(tokens[2]);

                IPerson person = new Citizen(name, country, age);
                IResident resident = new Citizen(name, country, age);

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());


                line = Console.ReadLine();
            }
        }
    }
}
