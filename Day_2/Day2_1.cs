using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class Item
    {
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; }

        public Item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    class Shopping
    {
        private List<Item> items = new List<Item>();

        public void Add_Item(Item item)
        {
            items.Add(item);
        }

        public void Display_Cart_Contents()
        {
            Console.WriteLine("Shopping Cart Contents:");
            foreach (Item item in items)
            {
                Console.WriteLine($"Item: {item.Name}, Price: ${item.Price}, Quantity: {item.Quantity}");
            }
        }

        public double Total_Cost
        {
            get
            {
                double total_cost = 0;
                foreach (Item item in items)
                {
                    total_cost += item.Price * item.Quantity;
                }
                return total_cost;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shopping cart = new Shopping();

            Item item1 = new Item("A", 10, 1);
            cart.Add_Item(item1);

            Item item2 = new Item("B", 20, 2);
            cart.Add_Item(item2);

            cart.Display_Cart_Contents();
            Console.WriteLine($"Total: Rs.{cart.Total_Cost:F2}");
        }
    }
}
