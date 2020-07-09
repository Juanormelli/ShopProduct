﻿namespace ShopStoAndre.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public virtual string PriceTag()
        {
            return "Product: " + Name + "Price: $" + Price.ToString("F2");
        }
    }
}
