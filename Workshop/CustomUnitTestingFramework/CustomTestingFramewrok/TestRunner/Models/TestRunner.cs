namespace CustomTestingFramework.TestRunner.Models
{
    using CustomTestingFramework.TestRunner.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;
    using System.Linq;
    using CustomTestingFramework.Attributes;
    using CustomTestingFramework.Exceptions;

    public class TestRunner : ITestRunner
    {

        private readonly IList<string> resultInfo;
        public TestRunner()
        {
            this.resultInfo = new List<string>();
        }

        public IList<string> Run(string path)
        {
            var testClasses = Assembly
                .LoadFrom(path)
                .GetTypes()
                .Where(x => x.CustomAttributes
                .Any(y => y.AttributeType == typeof(TestClassAttribute)))
                .ToList();


            foreach (var testClass in testClasses)
            {
                var testMethods = testClass
                    .GetMethods()
                    .Where(x => x.CustomAttributes
                    .Any(y => y.AttributeType == typeof(TestMethodAttribute)))
                    .ToList();

                var instance = Activator.CreateInstance(testClass);

                foreach (var method in testMethods)
                {
                    try
                    {
                        method.Invoke(instance, null);
                        resultInfo.Add($"Method: {method.Name} - passed!");

                    }
                    catch (TestException te)
                    {
                        resultInfo.Add($"Method: {method.Name} - failed!");
                    }
                    catch
                    {
                        resultInfo.Add($"Method: {method.Name} - Unexpected error occured!");
                    }

                }
            }

            return this.resultInfo;
        }
    }
}
