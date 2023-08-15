using System;

namespace OnlineStoreInventory
{
    class Product
    {
        public string Product_ID { get; }
        public string Name { get; }
        public double Price { get; }
        public int Quantity_In_Stock { get; }

        public Product(string product_ID, string name, double price, int quantity_In_Stock)
        {
            Product_ID = product_ID;
            Name = name;
            Price = price;
            Quantity_In_Stock = quantity_In_Stock;
        }

        public virtual void Display_Details()
        {
            Console.WriteLine($"Product ID: {Product_ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Quantity in Stock: {Quantity_In_Stock}");
        }
    }

    class Electronics : Product
    {
        public string Brand { get; }

        public Electronics(string product_ID, string name, double price, int quantity_In_Stock, string brand)
            : base(product_ID, name, price, quantity_In_Stock)
        {
            Brand = brand;
        }

        public override void Display_Details()
        {
            base.Display_Details();
            Console.WriteLine($"Brand: {Brand}");
        }
    }

    class Clothing : Product
    {
        public string Size { get; }

        public Clothing(string product_ID, string name, double price, int quantity_In_Stock, string size)
            : base(product_ID, name, price, quantity_In_Stock)
        {
            Size = size;
        }

        public override void Display_Details()
        {
            base.Display_Details();
            Console.WriteLine($"Size: {Size}");
        }
    }

    class Books : Product
    {
        public string Author { get; }

        public Books(string product_ID, string name, double price, int quantity_In_Stock, string author)
            : base(product_ID, name, price, quantity_In_Stock)
        {
            Author = author;
        }

        public override void Display_Details()
        {
            base.Display_Details();
            Console.WriteLine($"Author: {Author}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Electronics e = new Electronics("E1", "Laptop", 800, 10, "Dell");
            Clothing c = new Clothing("C1", "T-Shirt", 20, 50, "M");
            Books b = new Books("B1", "Harry Potter and the Sorcerer's Stone", 15, 20, "J.K. Rowling");

            e.Display_Details();
            Console.WriteLine();
            c.Display_Details();
            Console.WriteLine();
            b.Display_Details();
        }
    }
}
