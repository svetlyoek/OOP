namespace BirthdayCelebrations
{
    using BirthdayCelebrations.Runner;
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var starter = new Run();
            starter.Starter();
        }
    }
}
