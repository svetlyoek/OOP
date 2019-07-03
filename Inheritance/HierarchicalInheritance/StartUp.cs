using System;

namespace Farm
{
    public class StartUp
    {
        public static void Main()
        {
            var cat = new Cat();
            cat.Meow();
            cat.Eat();

            var dog = new Dog();
            dog.Eat();
            dog.Bark();

        }
    }
}
