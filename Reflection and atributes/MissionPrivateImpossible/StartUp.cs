namespace MissionPrivateImpossible
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            var spy = new Spy();
            string result = spy.RevealPrivateMethods("Hacker");
            Console.WriteLine(result.ToString());
        }
    }
}
