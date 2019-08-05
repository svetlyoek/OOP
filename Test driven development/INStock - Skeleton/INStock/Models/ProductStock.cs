namespace INStock.Models
{
    using INStock.Contracts;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class ProductStock : IProductStock
    {
        private IProduct[] products;
        private int initialSize = 5;
        private int addCounter = 0;
        public ProductStock()
        {
            this.products = new Product[initialSize];

        }

        public IProduct this[int index]
        {
            get
            {
                return this.products[index];
            }
            set
            {
                this.products[index] = value;
            }
        }

        public int Count
            => this.products.Count();

        public void Add(IProduct product)
        {
            this.products[addCounter] = product;
            this.addCounter++;
        }

        public bool Contains(IProduct product)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.products[i].Label == product.Label)
                {

                    return true;

                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public IProduct Find(int index)
        {
            IProduct product = this.products[index];

            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            return product;
        }

        public IEnumerable<IProduct> FindAllByPrice(decimal price)
        {
            return this.products.Where(x => x.Price == price);
        }

        public IEnumerable<IProduct> FindAllByQuantity(int quantity)
        {
            return this.products.Where(x => x.Quantity == quantity);
        }


        public IEnumerable<IProduct> FindAllInRange(decimal lo, decimal hi)
        {
            return this.products.Where(x => x.Price >= lo && x.Price <= hi).OrderByDescending(x => x.Price);
        }

        public IProduct FindByLabel(string label)
        {
            IProduct product = null;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.products[i].Label == label)
                {
                    return this.products[i];
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            return product;
        }

        public IProduct FindMostExpensiveProduct()
        {
            IProduct product = null;
            decimal maxPrice = decimal.MinValue;

            foreach (var item in this.products)
            {
                if (item.Price > maxPrice)
                {
                    maxPrice = item.Price;
                    product = item;
                }
            }
            return product;
        }


        public bool Remove(IProduct product)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.products[i] == product)
                {
                    this.products[i] = null;
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<IProduct> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
