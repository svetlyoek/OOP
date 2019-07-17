namespace DetailPrinter
{
    using Detail_Printer.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Employee : IWorker
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public string PrintEmployee(IWorker employee)
        {
            return $"{employee.Name}";
        }
    }
}
