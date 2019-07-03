using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main()
        {
            var randomList = new RandomList();

            Console.WriteLine(randomList.RandomString());
        }
    }
}
