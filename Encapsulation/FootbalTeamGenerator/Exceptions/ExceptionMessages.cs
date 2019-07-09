namespace FootbalTeamGenerator.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public static class ExceptionMessages
    {
        public static string invalidStatRange = "{0} should be between 0 and 100.";

        public static string invalidName = "A name should not be empty.";

        public static string invalidPlayer = "Player {0} is not in {1} team.";

        public static string invalidTeam = "Team {0} does not exist.";
    }
}
