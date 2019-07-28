namespace CustomTestingFramework.TestRunner.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface ITestRunner
    {
        IList<string> Run(string path);
    }
}
