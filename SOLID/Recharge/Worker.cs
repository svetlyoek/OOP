namespace Recharge
{
    public abstract class Worker
    {
        private string id;
        private int workingHours;

        public Worker(string id)
        {
            this.id = id;
        }

        public int WorkingHours { get; private set; }

        public virtual void Work(int hours)
        {
            this.WorkingHours += hours;
        }

    }
}