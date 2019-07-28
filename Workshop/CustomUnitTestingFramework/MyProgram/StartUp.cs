﻿using System;
using CustomTestingFramework.TestRunner;
using CustomTestingFramework.TestRunner.Models;

namespace MyProgram
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var runner = new TestRunner();

            var result = runner.Run(@"..\..\..\..\CustomTestingFramework.Tests\bin\Debug\netcoreapp2.2\CustomTestingFramework.Tests.dll");

            foreach (var info in result)
            {
                Console.WriteLine(info);
            }
        }
    }
}
