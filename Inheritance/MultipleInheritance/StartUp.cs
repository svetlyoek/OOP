using System;

namespace Farm
{
    public class StartUp
    {
        public static void Main()
        {
            var puppy = new Puppy();
            puppy.Bark();
            puppy.Eat();
            puppy.Weep();
        }
    }
}
