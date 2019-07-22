namespace CommandPattern
{
    using CommandPattern.Core.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string NAME_POSTFIX = "Command";
        public string Read(string args)
        {
            string[] commandTokens = args
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string commandName = commandTokens[0]
                + NAME_POSTFIX;

            string[] commandArgs = commandTokens
                .Skip(1)
                .ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();
            Type[] types = assembly.GetTypes();
            Type createType = types.FirstOrDefault(t => t.Name == commandName);

            Object instance = Activator.CreateInstance(createType);

            ICommand command = (ICommand)instance;

            string result = command.Execute(commandArgs);

            return result;

        }
    }
}
