using System.Collections.Generic;

namespace RawData
{
    public class CarFactory
    {
        public CarFactory()
        {
            this.Cars = new List<Car>();
        }

        public List<Car> Cars { get; private set; }

        public void Add(string[] carInfo)
        {

            string model = carInfo[0];
            int engineSpeed = int.Parse(carInfo[1]);
            int enginePower = int.Parse(carInfo[2]);
            int cargoWeight = int.Parse(carInfo[3]);
            string cargoType = carInfo[4];
            double tire1Pressure = double.Parse(carInfo[5]);
            double tire2Pressure = double.Parse(carInfo[7]);
            double tire3Pressure = double.Parse(carInfo[9]);
            double tire4Pressure = double.Parse(carInfo[11]);

            var engine = new Engine(engineSpeed, enginePower);
            var cargo = new Cargo(cargoWeight, cargoType);
            var currentTires = new Tire[4]
            {
                     new Tire(tire1Pressure,int.Parse(carInfo[6])),
                     new Tire(tire2Pressure,int.Parse(carInfo[8])),
                     new Tire(tire3Pressure,int.Parse(carInfo[10])),
                     new Tire(tire4Pressure,int.Parse(carInfo[12])),

            };

            var currentCar = new Car(model, engine, cargo, currentTires);
            this.Cars.Add(currentCar);

        }

        public List<Car> GetCar()
        {
            return this.Cars;
        }



    }
}
