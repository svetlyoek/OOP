using System.Collections.Generic;
namespace CarSalesman
{
    public class EngineFactory
    {
        public Engine MakeEngine(string[] engineInfo, List<Engine> engines)
        {
            string model = engineInfo[0];
            int power = int.Parse(engineInfo[1]);

            int displacement = -1;

            if (engineInfo.Length == 3 && int.TryParse(engineInfo[2], out displacement))
            {
                return new Engine(model, power, displacement);
            }
            else if (engineInfo.Length == 3)
            {
                string efficiency = engineInfo[2];
                return new Engine(model, power, efficiency);
            }
            else if (engineInfo.Length == 4)
            {
                string efficiency = engineInfo[3];
                return new Engine(model, power, int.Parse(engineInfo[2]), efficiency);
            }
            else
            {
                return new Engine(model, power);
            }
        }
    }
}
