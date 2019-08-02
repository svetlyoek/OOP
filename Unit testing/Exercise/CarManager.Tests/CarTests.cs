using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            this.car = new Car("Opel", "Vectra", 8.5, 55.4);
        }

        [Test]
        public void TestConstructorIfWorskCorrectly()
        {
            Assert.AreEqual("Opel", this.car.Make);
            Assert.AreEqual("Vectra", this.car.Model);
            Assert.AreEqual(8.5, this.car.FuelConsumption);
            Assert.AreEqual(55.4, this.car.FuelCapacity);
            Assert.AreEqual(0, this.car.FuelAmount);
        }

        [Test]
        public void TestConstructorShouldThrowExceptionWhenMakeIsNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var car = new Car(null, "Vectra", 8.7, 54.3);
            });
        }

        [Test]
        public void TestConstructorShouldThrowExceptionWhenModelIsNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var car = new Car("Ford", null, 8.7, 54.3);
            });
        }

        [Test]
        public void TestConstructorShouldThrowExceptionWhenFuelConsumptionIsZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var car = new Car("Ford", "Focus", 0, 46.5);
            });
        }

        [Test]
        public void TestConstructorShouldThrowExceptionWhenFuelConsumptionIsNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var car = new Car("Ford", "Focus", -5.6, 46.5);
            });
        }

        [Test]
        public void TestConstructorShouldThrowExceptionWhenFuelCapacityIsZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var car = new Car("Ford", "Focus", 5.6, 0);
            });

        }

        [Test]
        public void TestConstructorShouldThrowExceptionWhenFuelCapacityIsNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var car = new Car("Ford", "Focus", 5.6, -50.6);
            });

        }

        [Test]
        public void TestRefuelIfWorksCorrectlyWhenFuelAmountNotMoreThanCapacity()
        {
            double refuelAmount = 20.5;

            this.car.Refuel(refuelAmount);

            Assert.AreEqual(refuelAmount, this.car.FuelAmount);
        }

        [Test]
        public void TestRefuelIfWorksCorrectlyWhenFuelAmountIsMoreThanCapacity()
        {
            double refuelAmount = 70.5;

            this.car.Refuel(refuelAmount);

            Assert.AreEqual(55.4, this.car.FuelAmount);
        }

        [Test]
        public void TestRefuelShouldThrowExceptionIfRefuelIsZero()
        {
            double refuelAmount = 0;

            Assert.Throws<ArgumentException>(() =>
            {
                this.car.Refuel(refuelAmount);
            });
        }

        [Test]
        public void TestRefuelShouldThrowExceptionIfRefuelIsNegative()
        {
            double refuelAmount = -20.5;

            Assert.Throws<ArgumentException>(() =>
            {
                this.car.Refuel(refuelAmount);
            });
        }

        [Test]
        public void TestDriveIfWorksCorrectly()
        {
            this.car.Refuel(40.5);

            this.car.Drive(20.5);

            Assert.AreEqual(38.7575, this.car.FuelAmount);
        }

        [Test]
        public void TestDriveShouldThrowExceptionWhenNeededFuelIsMoreThanCurrentAmount()
        {
            this.car.Refuel(10.5);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.car.Drive(200.50);

            });
        }




    }
}