namespace Ferrari
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string driverName = Console.ReadLine();

            IDriver driver = new Ferrari(driverName);

            Console.WriteLine(driver.ToString());
        }
    }
}
