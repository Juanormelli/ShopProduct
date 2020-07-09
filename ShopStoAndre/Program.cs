using Microsoft.VisualBasic;
using ShopStoAndre.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ShopStoAndre
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product {i} Data");
                Console.Write("New, Imported or Used  (N/I/U): ");
                char state = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (state == 'I')
                {
                    Console.Write("Costoms fee: ");
                    double costoms = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, costoms));
                }
                else if (state == 'U')
                {
                    Console.Write("Date od Manufacture: (dd/mm/yyyy): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    products.Add(new Product(name, price));
                }

            }
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
