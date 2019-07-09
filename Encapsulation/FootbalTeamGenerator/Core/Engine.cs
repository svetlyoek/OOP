namespace FootbalTeamGenerator.Core
{
    using FootbalTeamGenerator.Exceptions;
    using FootbalTeamGenerator.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Engine
    {
        private readonly List<Team> teams;

        public Engine()
        {
            this.teams = new List<Team>();
        }

        public void Run()
        {

            string input = Console.ReadLine();

            while (input != "END")
            {
                try
                {
                    string[] commands = input
                      .Split(";", StringSplitOptions.RemoveEmptyEntries)
                      .ToArray();

                    string command = commands[0];
                    string teamName = commands[1];

                    if (command == "Team")
                    {
                        var team = new Team(teamName);

                        if (!this.teams.Contains(team))
                        {
                            this.teams.Add(team);
                        }

                    }

                    else if (command == "Add")
                    {
                        string playerName = commands[2];
                        int endurance = int.Parse(commands[3]);
                        int sprint = int.Parse(commands[4]);
                        int dribble = int.Parse(commands[5]);
                        int passing = int.Parse(commands[6]);
                        int shooting = int.Parse(commands[7]);

                        var stat = new Stat(endurance, sprint, dribble, passing, shooting);
                        var player = new Player(playerName, stat);

                        var team = this.teams.FirstOrDefault(x => x.Name == teamName);

                        if (team != null)
                        {
                            team.AddPlayer(player);
                        }

                        else
                        {
                            Console.WriteLine($"Player {playerName} is not in {team.Name} team.");
                        }
                    }

                    else if (command == "Remove")
                    {
                        string playerName = commands[2];

                        var team = this.teams.FirstOrDefault(x => x.Name == teamName);

                        if (team != null)
                        {
                            team.RemovePlayer(playerName);
                        }

                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                    }

                    else if (command == "Rating")
                    {
                        var team = this.teams.FirstOrDefault(x => x.Name == teamName);

                        if (team != null)
                        {
                            Console.WriteLine(teams.Find(x => x.Name == teamName).Rating());
                        }

                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }

                    }
                }

                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
