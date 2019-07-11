namespace FoodShortage
{
    using FoodShortage.Runner;
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var runner = new Run();
            runner.Starter();
        }
    }
}
