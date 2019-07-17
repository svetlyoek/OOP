namespace DetailPrinter
{
    using Detail_Printer.Contracts;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            IWorker firstEmployee = new Employee("Ivan");
            IWorker secondEmployee = new Employee("Dido");
            IWorker thirdEmployee = new Employee("Pencho");

            IWorker firstmanager = new Manager("Gosho", new List<string> { "Music", "Documents", "Wallpapers" });
            IWorker secondmanager = new Manager("Sotir", new List<string> { "Recycle bin", "Photos" });

            var printer = new DetailsPrinter(new List<IWorker> { firstEmployee, secondEmployee, thirdEmployee, firstmanager, secondmanager });

            printer.PrintDetails();
        }
    }
}
