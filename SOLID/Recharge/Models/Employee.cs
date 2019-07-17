namespace Recharge
{
    using System;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id)
            : base(id)
        {
        }

        public string Sleep()
        {
            return $"{this.GetType().Name} is sleeping...";
        }
    }
}
