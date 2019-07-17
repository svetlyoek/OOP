namespace Detail_Printer.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface IWorker
    {
        string Name { get; }

        string PrintEmployee(IWorker employee);
    }
}
