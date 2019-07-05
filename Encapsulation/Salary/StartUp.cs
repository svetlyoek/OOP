namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var people = new List<Person>();

            int inputCounter = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCounter; i++)
            {
                string[] lines = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstName = lines[0];
                string lastName = lines[1];
                int age = int.Parse(lines[2]);
                decimal salary = decimal.Parse(lines[3]);
                var person = new Person(firstName, lastName, age, salary);

                people.Add(person);
            }

            decimal percentage = decimal.Parse(Console.ReadLine());

            people.ForEach(p => p.IncreaseSalary(percentage));

            people.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
