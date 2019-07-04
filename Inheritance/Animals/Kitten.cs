﻿namespace Animals
{
    public class Kitten : Cat
    {
        private const string kitten = "female";
        public Kitten(string name, int age)
            : base(name, age, kitten)
        {
        }

        public override string ProduceSound()
        {
            return "Meow meow";
        }
    }
}
