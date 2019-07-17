namespace DetailPrinter
{
    using Detail_Printer.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class DetailsPrinter
    {
        private IList<IWorker> employees;

        public DetailsPrinter(IList<IWorker> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (IWorker employee in this.employees)
            {
                Console.WriteLine(employee.PrintEmployee(employee));

            }
        }
    }
}
