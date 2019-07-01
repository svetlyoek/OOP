using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class CarSalesman
    {
        private EngineFactory engineFactory;
        private CarFactory carFactory;
        private List<Car> cars;
        private List<Engine> engines;
        public CarSalesman(CarFactory carFactory, EngineFactory engineFactory)
        {
            this.cars = new List<Car>();
            this.engines = new List<Engine>();
            this.carFactory = carFactory;
            this.engineFactory = engineFactory;
        }

        public void AddEngine(string[] engineInfo)
        {
            var engine = engineFactory.MakeEngine(engineInfo, this.engines);
            engines.Add(engine);
        }

        public void AddCar(string[] carInfo)
        {
            var car = carFactory.MakeCar(carInfo, this.engines);
            cars.Add(car);
        }

        public List<Car> GetCar()
        {
            return this.cars;
        }
    }
}
