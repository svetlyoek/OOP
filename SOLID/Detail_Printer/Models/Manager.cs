namespace DetailPrinter
{
    using Detail_Printer.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Manager : IWorker
    {
        public Manager(string name, ICollection<string> documents)

        {
            this.Name = name;
            this.Documents = new List<string>(documents);
        }

        public string Name { get; private set; }
        public IReadOnlyCollection<string> Documents { get; private set; }

        public string PrintEmployee(IWorker employee)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(employee.Name + ":");
            result.AppendLine(string.Join(Environment.NewLine, this.Documents));

            return result.ToString().TrimEnd();
        }
    }
}
