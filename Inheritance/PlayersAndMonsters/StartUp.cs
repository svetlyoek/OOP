using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string heroName = Console.ReadLine();
            int heroLevel = int.Parse(Console.ReadLine());

            var elf = new Elf(heroName, heroLevel);
            var knight = new Knight(heroName, heroLevel);

            Console.WriteLine(elf);
            Console.WriteLine(knight);


        }
    }
}