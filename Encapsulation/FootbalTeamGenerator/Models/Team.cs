namespace FootbalTeamGenerator.Models
{
    using FootbalTeamGenerator.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Team
    {
        private string name;
        private readonly List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
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

        public IReadOnlyList<Player> Players
            => this.players.AsReadOnly();

        public string Rating()
        {
            if (Players.Count == 0)
            {
                return "" + this.Name + " - " + "0";
            }
            var average = Players.Average(x => x.Stat.GetAgevare());

            return "" + this.Name + " - " + (int)(average / Players.Count);
        }

        public void AddPlayer(Player player)
        {
            if (player != null)
            {
                this.players.Add(player);
            }

        }

        public void RemovePlayer(string player)
        {
            var currentPlayer = this.players.FirstOrDefault(p => p.Name == player);

            if (currentPlayer != null)
            {
                this.players.Remove(currentPlayer);
            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.invalidPlayer, player, this.Name));
            }
        }

    }
}

