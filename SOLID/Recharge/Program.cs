namespace Recharge
{
    using System;

    class Program
    {
        static void Main()
        {
            var employee = new Employee("123");
            var robot = new Robot("666", 200);

            Console.WriteLine(employee.Sleep());
            employee.Work(8);
            Console.WriteLine(employee.WorkingHours);

            var beforePower = robot.CurrentPower;
            Console.WriteLine(beforePower);
            robot.Recharge();
            var afterPower = robot.CurrentPower;
            Console.WriteLine(afterPower);
            robot.Work(12);
            var afterWorkPower = robot.CurrentPower;
            Console.WriteLine(afterWorkPower);
        }
    }
}
