using System;
using System.Linq;

namespace PointInRectangle
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            Point leftPoints = new Point(coordinates[0], coordinates[1]);
            Point rightPoints = new Point(coordinates[2], coordinates[3]);
            Rectangle rectangle = new Rectangle(leftPoints, rightPoints);

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                int[] pointsToCheck = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

                Point pointToCheck = new Point(pointsToCheck[0], pointsToCheck[1]);
                Console.WriteLine(rectangle.Contains(pointToCheck));
            }
        }
    }
}
