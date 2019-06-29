using System;

namespace RhombusOfStars
{
    public class Program
    {
        static void Main(string[] args)
        {
            int stars = int.Parse(Console.ReadLine());

            for (int starCount = 1; starCount <= stars; starCount++)
            {
                PrintRow(stars, starCount);
            }

            for (int starCount = stars-1 ; starCount >= 1; starCount--)
            {
                PrintRow(stars, starCount);
            }
        }

        private static void PrintRow(int stars, int starCount)
        {
            int spaces = stars - starCount;

            Console.Write(new string(' ', spaces));

            for (int i = 1; i <= starCount; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

        }

    }
}
