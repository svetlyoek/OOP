using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string gorillaName = Console.ReadLine();
            string snakeName = Console.ReadLine();

            var gorilla = new Gorilla(gorillaName);
            var snake = new Snake(snakeName);

            Console.WriteLine($"Gorilla's name: {gorilla.Name}");
            Console.WriteLine($"Snake's name: {snake.Name}");

        }
    }
}
