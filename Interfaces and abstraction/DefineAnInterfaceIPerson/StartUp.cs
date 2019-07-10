namespace PersonInfo
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                IPerson person = new Citizen(name, age);
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
