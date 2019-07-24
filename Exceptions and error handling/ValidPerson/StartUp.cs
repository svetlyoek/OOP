namespace ValidPerson
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var firstPerson = new Person("Ivan", "Dimitrov", 23);

            try
            {
                var secondPerson = new Person("", "Petrov", 45);
                var thirdPerson = new Person("Ivan", null, 67);
                var fourthPerson = new Person("Ivan", "Petkov", -2);
                var fifthPerson = new Person("Ivan", "Mihailov", 124);

            }
            catch (ArgumentNullException ane)
            {

                Console.WriteLine($"Exception thrown: {ane.Message}");
            }
            catch (ArgumentOutOfRangeException aofre)
            {
                Console.WriteLine($"Exception thrown: {aofre.Message}");
            }

            finally
            {
                Console.WriteLine($"Name: {firstPerson.FirstName + " " + firstPerson.LastName}"
                   + Environment.NewLine
                   + $"Age: {firstPerson.Age}");
            }
        }
    }
}
