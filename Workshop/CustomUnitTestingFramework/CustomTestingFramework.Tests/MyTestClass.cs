using System;
using CustomTestingFramework.Asserts;
using CustomTestingFramework.Attributes;

namespace CustomTestingFramework.Tests
{
    [TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void ShouldSumValues()
        {
            int a = 2;
            int b = 3;

            int actualSum = a + b;
            int expectedResult = 5;

            Assert.AreEqual(actualSum, expectedResult);
        }

        [TestMethod]
        public void ShouldSumValuesSecond()
        {
            int a = 2;
            int b = 3;

            int actualSum = a + b;
            int expectedResult = 6;

            Assert.AreNotEqual(actualSum, expectedResult);
        }

        [TestMethod]
        public void ShouldSumValuesThird()
        {
            var a = new string[5];

            Assert.Throws<IndexOutOfRangeException>(() => a[12] == "Lalala");
        }

    }
}
