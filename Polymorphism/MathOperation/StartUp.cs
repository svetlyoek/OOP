﻿namespace Operations
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var mathOperation = new MathOperations();

            Console.WriteLine(mathOperation.Add(2, 3));
            Console.WriteLine(mathOperation.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mathOperation.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
