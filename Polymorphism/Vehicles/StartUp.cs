namespace Vehicles
{
    using System;
    using Vehicles.Core;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var engine = new Engine();
            engine.Run();
        }
    }
}
