namespace SquareRoot
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine(Math.Sqrt(number));

            }
            catch (FormatException fe)
            {
                throw new FormatException("Invalid number", fe);
            }

            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
