namespace FootbalTeamGenerator.Models
{
    using FootbalTeamGenerator.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Player
    {
        private string name;
        private Stat stat;

        public Player(string name, Stat stat)
        {
            this.Name = name;
            this.Stat = stat;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.invalidName);
                }

                this.name = value;
            }
        }

        public Stat Stat { get; private set; }


        public double OverallSkillLevel
            => (this.Stat.Endurance + this.Stat.Sprint + this.Stat.Dribble + this.Stat.Passing + this.Stat.Shooting) / 5;
    }
}
