namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;
        public Person(string name, decimal money)
        {
            this.products = new List<Product>();
            this.Name = name;
            this.Money = money;
        }

        public Dictionary<string, List<string>> Products { get; private set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public string AddProduct(Product product)
        {
            if (product.Cost > this.Money)
            {
                return $"{this.Name} can't afford {product.Name}";
            }

            this.products.Add(product);
            this.Money -= product.Cost;

            return $"{this.Name} bought {product.Name}";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.products.Count == 0)
            {
                sb.AppendLine($"{this.Name} - Nothing bought");
            }
            else
            {
                List<string> productsNames = new List<string>();

                this.products.ForEach(p => productsNames.Add(p.Name));

                sb.Append($"{this.Name} - {string.Join(", ", productsNames)}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
