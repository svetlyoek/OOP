using System;
using System.Linq;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main()
        {
            string[] items = Console.ReadLine()
                .Split()
                .ToArray();

            var stackOfString = new StackOfStrings();

            Console.WriteLine(string.Join(" ",stackOfString.PushRange(items)));
        }
    }
}
