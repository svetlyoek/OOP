namespace CustomException
{
    using CustomException.Exceptions;
    using CustomException.Models;
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                var firstStudent = new Student("Ivan", "ivan@gmail.com");

                Console.WriteLine($"Student name: {firstStudent.Name}"
                    + Environment.NewLine
                    + $"Email: {firstStudent.Email}");
            }

            catch (InvalidPersonNameException)
            {
                throw new InvalidPersonNameException();
            }

            try
            {
                var secondStudent = new Student("Ivan4o", "ivan@gmail.com");

                Console.WriteLine($"Student name: {secondStudent.Name}"
                    + Environment.NewLine
                    + $"Email: {secondStudent.Email}");
            }

            catch (InvalidPersonNameException)
            {
                throw new InvalidPersonNameException();
            }

        }
    }
}
