namespace FootbalTeamGenerator.Models
{
    using FootbalTeamGenerator.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Stat
    {
        private const int MIN_STAT_VALUE = 0;
        private const int MAX_STAT_VALUE = 100;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private int[] averageStats;
        public Stat(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            averageStats = new[] { endurance, sprint, dribble, passing, shooting };
        }

        public int Endurance
        {
            get
            {
                return this.endurance;
            }

            private set
            {
                if (value < MIN_STAT_VALUE || value > MAX_STAT_VALUE)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.invalidStatRange, nameof(this.Endurance)));
                }

                this.endurance = value;
            }
        }

        public int Sprint
        {
            get
            {
                return this.sprint;
            }

            private set
            {
                if (value < MIN_STAT_VALUE || value > MAX_STAT_VALUE)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.invalidStatRange, nameof(this.Sprint)));
                }

                this.sprint = value;
            }
        }

        public int Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {
                if (value < MIN_STAT_VALUE || value > MAX_STAT_VALUE)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.invalidStatRange, nameof(this.Dribble)));
                }

                this.dribble = value;
            }
        }

        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                if (value < MIN_STAT_VALUE || value > MAX_STAT_VALUE)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.invalidStatRange, nameof(this.Passing)));
                }

                this.passing = value;
            }
        }

        public int Shooting
        {
            get
            {
                return this.shooting;
            }

            private set
            {
                if (value < MIN_STAT_VALUE || value > MAX_STAT_VALUE)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.invalidStatRange, nameof(this.Shooting)));
                }

                this.shooting = value;
            }
        }

        public double GetAgevare()
        {
            double current = averageStats.Average(x => x);
            return Math.Ceiling(current);
        }

    }
}
