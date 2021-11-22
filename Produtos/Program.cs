using System;
using System.Globalization;
using Produtos.Entities;
using System.Collections.Generic;

namespace Produtos {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == "c") {
                    list.Add(new Product(name, price));
                }

                else if (type == "u"){
                    Console.Write("Manufacutre date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufactureDate));
                }

                else if (type == "i") {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine();

            Console.WriteLine("PRICE TAGS");
            foreach (Product p in list) {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
