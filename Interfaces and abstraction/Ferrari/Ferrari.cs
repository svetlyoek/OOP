namespace Ferrari
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Ferrari : Car, IDriver
    {
        public Ferrari(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public override string ToString()
        {
            return $"488-Spider/{this.PushBrakes()}/{this.PushGas()}/{this.Name}";
        }
    }
}
