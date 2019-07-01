using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class CarFactory
    {
        public Car MakeCar(string[] carInfo, List<Engine> engines)
        {
            string model = carInfo[0];
            string engineModel = carInfo[1];
            Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

            int weight = -1;

            if (carInfo.Length == 3 && int.TryParse(carInfo[2], out weight))
            {
                return new Car(model, engine, weight);
            }
            else if (carInfo.Length == 3)
            {
                string color = carInfo[2];
                return new Car(model, engine, color);
            }
            else if (carInfo.Length == 4)
            {
                string color = carInfo[3];
                return new Car(model, engine, int.Parse(carInfo[2]), color);
            }
            else
            {
                return new Car(model, engine);
            }
        }
    }
}
