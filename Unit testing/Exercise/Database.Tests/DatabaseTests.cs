using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database.Database dataBase;

        [SetUp]
        public void Setup()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            this.dataBase = new Database.Database(numbers);
        }

        [Test]
        public void TestConstructorShouldReturnCollectionCount()
        {
            Assert.AreEqual(16, this.dataBase.Count);
        }

        [Test]
        public void TestAddShouldThrowExceptionWhenMoreThanSixteenElements()
        {
            Assert.Throws<InvalidOperationException>(() => this.dataBase.Add(17));
        }

        [Test]
        public void TestAddShouldAddElementInCollection()
        {
            this.dataBase = new Database.Database(1, 2, 3, 4);

            this.dataBase.Add(5);

            Assert.AreEqual(5, this.dataBase.Count);
        }

        [Test]
        public void TestRemoveThrowsExceptionWhenEmpty()
        {
            this.dataBase = new Database.Database();

            Assert.Throws<InvalidOperationException>(() => this.dataBase.Remove());
        }

        [Test]
        public void TestRemoveDoNotThrowExceptionWhenNotEmpty()
        {
            this.dataBase.Remove();

            Assert.AreEqual(15, this.dataBase.Count);
        }

        [Test]
        public void TestFetchMakeNewCollectionEqualToDatabase()
        {
            Assert.AreEqual(16, this.dataBase.Fetch().Length);
        }

    }
}