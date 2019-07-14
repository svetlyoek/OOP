namespace VehiclesExtension
{
    using System;
    using VehiclesExtension.Core;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var engine = new Engine();
            engine.Run();
        }
    }
}
