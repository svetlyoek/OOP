using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    public class Engine
    {
        private const int room = 1;

        public static void StartUp()
        {
            var doctors = new Dictionary<string, List<string>>();
            var departments = new Dictionary<string, List<List<string>>>();

            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var departament = tokens[0];
                var firstName = tokens[1];
                var secondName = tokens[2];
                var patient = tokens[3];

                var fullName = firstName + " " + secondName;

                if (!doctors.ContainsKey(fullName))
                {
                    doctors[fullName] = new List<string>();
                }

                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();

                    for (int currentRoom = 1; currentRoom <= 20; currentRoom++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                bool isFree = departments[departament].SelectMany(x => x).Count() < 60;

                if (isFree)
                {

                    doctors[fullName].Add(patient);

                    for (int currentRoom = 1; currentRoom <= departments[departament].Count; currentRoom++)
                    {
                        if (departments[departament][currentRoom].Count < 3)
                        {
                            int room = currentRoom;
                            break;
                        }
                    }

                    departments[departament][room].Add(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] outputArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (outputArgs.Length == 1)
                {
                    FilterpatientInDepartment(outputArgs, departments);
                }


                else if (outputArgs.Length == 2)
                {
                    bool isRoom = int.TryParse(outputArgs[1], out int room);

                    if (isRoom)
                    {
                        FilterPatientInRoom(departments, outputArgs);
                    }

                    else
                    {
                        FilterpatientsForDoctor(outputArgs, doctors);
                    }
                }

                command = Console.ReadLine();
            }

        }

        private static void FilterpatientsForDoctor(string[] outputArgs, Dictionary<string, List<string>> doctors)
        {
            var currentDoctor = outputArgs[0] + " " + outputArgs[1];
            var patientsForDoctor = doctors[currentDoctor].OrderBy(p => p).ToArray();

            PrintOutput(patientsForDoctor);
        }

        private static void FilterPatientInRoom(Dictionary<string, List<List<string>>> departments, string[] outputArgs)
        {
            var currentDepartment = outputArgs[0];
            var patientInRoomToPrint = departments[currentDepartment][room].OrderBy(p => p).ToArray();

            PrintOutput(patientInRoomToPrint);
        }

        private static void FilterpatientInDepartment(string[] outputArgs, Dictionary<string, List<List<string>>> departments)
        {
            var currentDepartment = outputArgs[0];
            var patientInDepToPrint = departments[currentDepartment].Where(d => d.Count > 0).SelectMany(d => d).ToArray();

            PrintOutput(patientInDepToPrint);
        }

        private static void PrintOutput(string[] patients)
        {
            Console.WriteLine(string.Join(Environment.NewLine, patients));
        }
    }
}




