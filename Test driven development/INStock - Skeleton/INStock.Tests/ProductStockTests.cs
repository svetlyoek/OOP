namespace INStock.Tests
{
    using INStock.Contracts;
    using INStock.Models;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductStockTests
    {
        private IProductStock productStock;
        private IProduct product;

        [SetUp]
        public void SetUp()
        {
            this.productStock = new ProductStock();
            this.product = new Product("SSD", 89.76m, 2);
        }

        [Test]
        public void TestAddShouldAddProductInProductStockCorrectly()
        {
            this.productStock.Add(this.product);

            Assert.AreSame(this.productStock[0], this.product);
        }

        [Test]
        public void TestContainsShouldReturnTrueIfFindElementWithUniqueLabel()
        {
            this.productStock.Add(this.product);

            Assert.IsTrue(this.productStock.Contains(this.product));
        }

        [Test]
        public void TestContainsShouldReturnFalseIfNoElementWithUniqueLabel()
        {
            var productToSearch = new Product("Chocolate", 12.5m, 13);

            this.productStock.Add(productToSearch);

            Assert.IsFalse(this.productStock.Contains(this.product));
        }

        [Test]
        public void TestCountShouldReturnTheSizeCorrectly()
        {
            var firstProduct = new Product("HDD", 12.5m, 13);
            var secondProduct = new Product("Chocolate", 12.5m, 13);
            var thirdProduct = new Product("Clothes", 12.5m, 13);
            var fourthProduct = new Product("Whiskey", 12.5m, 13);
            var fifthProduct = new Product("Bread", 12.5m, 13);

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);
            this.productStock.Add(fourthProduct);
            this.productStock.Add(fifthProduct);

            Assert.AreEqual(5, this.productStock.Count);
        }

        [Test]
        public void TestFindShouldReturnElementInGivenIndex()
        {
            var firstProduct = new Product("HDD", 12.5m, 13);
            var secondProduct = new Product("Chocolate", 12.5m, 13);

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);

            this.productStock.Find(1);

            Assert.AreSame(secondProduct, this.productStock[1]);
        }

        [Test]
        public void TestFindShoudlThrowExceptionWhenIndexOutOfRange()
        {
            var firstProduct = new Product("HDD", 12.5m, 13);
            var secondProduct = new Product("Chocolate", 12.5m, 13);

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);


            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                this.productStock.Find(8);
            });
        }

        [Test]
        public void TestFindByLabelShouldReturnCorrectObject()
        {
            var firstProduct = new Product("HDD", 12.5m, 13);
            var secondProduct = new Product("Chocolate", 12.5m, 13);

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);

            Assert.AreSame(firstProduct, this.productStock.FindByLabel("HDD"));
        }

        [Test]
        public void TestFindByLabelShouldThrowExceptionWhenNoProductWithGivenLabel()
        {
            var firstProduct = new Product("HDD", 12.5m, 13);
            var secondProduct = new Product("Chocolate", 12.5m, 13);

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);

            Assert.Throws<ArgumentException>(() =>
            {
                this.productStock.FindByLabel("Clothes");
            });
        }

        [Test]
        public void TestFindAllInPriceRangeShouldReturnElementsCorrectly()
        {
            var firstProduct = new Product("HDD", 12.5m, 13);
            var secondProduct = new Product("Chocolate", 12.8m, 13);
            var thirdProduct = new Product("Clothes", 30.12m, 13);
            var fourthProduct = new Product("Whiskey", 150.43m, 13);
            var fifthProduct = new Product("Bread", 1.05m, 13);

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);
            this.productStock.Add(fourthProduct);
            this.productStock.Add(fifthProduct);

            decimal startPrice = 25.5m;
            decimal endPrice = 150.9m;
            var products = this.productStock.FindAllInRange(startPrice, endPrice);

            Assert.That(products.Count() == 2);
        }

        [Test]
        public void TestFindAllInPriceRangeShouldReturnEmptyCollectionWhenNoElementsFind()
        {
            var firstProduct = new Product("HDD", 12.5m, 13);
            var secondProduct = new Product("Chocolate", 12.8m, 13);
            var thirdProduct = new Product("Clothes", 30.12m, 13);
            var fourthProduct = new Product("Whiskey", 150.43m, 13);
            var fifthProduct = new Product("Bread", 1.05m, 13);

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);
            this.productStock.Add(fourthProduct);
            this.productStock.Add(fifthProduct);

            decimal startPrice = 200.56m;
            decimal endPrice = 345.12m;
            var products = this.productStock.FindAllInRange(startPrice, endPrice);
            Assert.That(products.Count() == 0);
        }

        [Test]
        public void TestFindAllByPriceShouldWorksCorrectly()
        {
            var firstProduct = new Product("HDD", 12.8m, 13);
            var secondProduct = new Product("Chocolate", 12.8m, 13);
            var thirdProduct = new Product("Clothes", 30.12m, 13);
            var fourthProduct = new Product("Whiskey", 150.43m, 13);
            var fifthProduct = new Product("Bread", 1.05m, 13);

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);
            this.productStock.Add(fourthProduct);
            this.productStock.Add(fifthProduct);

            decimal price = 12.8m;

            var products = this.productStock.FindAllByPrice(price);

            Assert.That(products.Count() == 2);
        }

        [Test]
        public void TestFindAllByPriceShouldReturnEmptyEnumerationIfNoElements()
        {
            var firstProduct = new Product("HDD", 12.8m, 13);
            var secondProduct = new Product("Chocolate", 12.8m, 13);
            var thirdProduct = new Product("Clothes", 30.12m, 13);
            var fourthProduct = new Product("Whiskey", 150.43m, 13);
            var fifthProduct = new Product("Bread", 1.05m, 13);

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);
            this.productStock.Add(fourthProduct);
            this.productStock.Add(fifthProduct);

            decimal price = 345.76m;

            var products = this.productStock.FindAllByPrice(price);

            Assert.That(products.Count() == 0);
        }

        [Test]
        public void TestFindAllByQuantityShouldWorskCorrectly()
        {
            var firstProduct = new Product("HDD", 12.8m, 13);
            var secondProduct = new Product("Chocolate", 12.8m, 13);
            var thirdProduct = new Product("Clothes", 30.12m, 13);
            var fourthProduct = new Product("Whiskey", 150.43m, 13);
            var fifthProduct = new Product("Bread", 1.05m, 13);

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);
            this.productStock.Add(fourthProduct);
            this.productStock.Add(fifthProduct);

            int quantity = 13;

            var products = this.productStock.FindAllByQuantity(quantity);

            Assert.That(products.Count() == 5);
        }

        [Test]
        public void TestFindAllByQuantityShouldReturnEmptyEnumerationWhenNoElements()
        {
            var firstProduct = new Product("HDD", 12.8m, 13);
            var secondProduct = new Product("Chocolate", 12.8m, 13);
            var thirdProduct = new Product("Clothes", 30.12m, 13);
            var fourthProduct = new Product("Whiskey", 150.43m, 13);
            var fifthProduct = new Product("Bread", 1.05m, 13);

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);
            this.productStock.Add(fourthProduct);
            this.productStock.Add(fifthProduct);

            int quantity = 14;

            var products = this.productStock.FindAllByQuantity(quantity);

            Assert.That(products.Count() == 0);
        }

        [Test]
        public void TestFindMostExpensiveProductShouldReturnMostExpensiveProductCorrectly()
        {
            var firstProduct = new Product("HDD", 12.5m, 13);
            var secondProduct = new Product("Chocolate", 12.8m, 13);
            var thirdProduct = new Product("Clothes", 30.12m, 13);
            var fourthProduct = new Product("Whiskey", 150.43m, 13);
            var fifthProduct = new Product("Bread", 1.05m, 13);

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);
            this.productStock.Add(thirdProduct);
            this.productStock.Add(fourthProduct);
            this.productStock.Add(fifthProduct);

            Assert.AreSame(fourthProduct, this.productStock.FindMostExpensiveProduct());
        }

        [Test]
        public void TestRemoveShouldReturnTrueWhenRemoveElementSuccessfully()
        {
            var firstProduct = new Product("HDD", 12.5m, 13);
            var secondProduct = new Product("Chocolate", 12.8m, 13);


            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);

            Assert.IsTrue(this.productStock.Remove(firstProduct));
        }

        [Test]
        public void TestRemoveShouldReturnFalseIfCanNotRemoveElement()
        {
            var firstProduct = new Product("HDD", 12.5m, 13);
            var secondProduct = new Product("Chocolate", 12.8m, 13);


            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);

            Assert.IsFalse(this.productStock.Remove(new Product("Clothes", 27.8m, 13)));
        }
    }
}
