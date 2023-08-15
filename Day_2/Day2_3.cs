using System;
using System.Collections.Generic;

namespace OnlineStore
{
    class Product
    {
        public string Name { get; }
        public double Price { get; }
        public int Quantity_In_Stock { get; private set; }
        public string Category { get; }

        public Product(string name, double price, int quantity_In_Stock, string category)
        {
            Name = name;
            Price = price;
            Quantity_In_Stock = quantity_In_Stock;
            Category = category;
        }

        public void Decrease_Stock(int quantity)
        {
            Quantity_In_Stock -= quantity;
        }

        public void Increase_Stock(int quantity)
        {
            Quantity_In_Stock += quantity;
        }
    }

    class Store
    {
        private List<Product> products = new List<Product>();

        public void Add_Product(Product product)
        {
            products.Add(product);
        }

        public void Display_Products()
        {
            Console.WriteLine("Store Products List:");
            foreach (Product product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: ${product.Price}, Quantity in Stock: {product.Quantity_In_Stock}, Category: {product.Category}");
            }
        }

        public double Calculate_Total_Value()
        {
            double totalValue = 0;
            foreach (Product product in products)
            {
                totalValue += product.Price * product.Quantity_In_Stock;
            }
            return totalValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Product product1 = new Product("A",10,1,"Electronics");
            store.Add_Product(product1);

            Product product2 = new Product("B",20,2,"Clothing");
            store.Add_Product(product2);

            store.Display_Products();
            Console.WriteLine($"Total Value: Rs.{store.Calculate_Total_Value():F2}");
        }
    }
}
