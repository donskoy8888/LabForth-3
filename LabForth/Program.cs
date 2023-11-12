using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Shop shop = new Shop();

        shop.AddProduct(new Product
        {
            Name = "Laptop",
            Price = 1200.0,
            Description = "Powerful laptop for all your needs",
            Category = "Electronics",
            Rating = 4.5,
            AvailableQuantity = 10
        });

        shop.AddProduct(new Product
        {
            Name = "Smartphone",
            Price = 800.0,
            Description = "Latest smartphone with great features",
            Category = "Electronics",
            Rating = 4.2,
            AvailableQuantity = 20
        });

        User user = new User
        {
            Username = "john_doe",
            Password = "password123",
            PurchaseHistory = new List<Order>()
        };

        shop.RegisterUser(user);

        List<Product> selectedProducts = shop.Search("laptop");
        List<int> quantities = new List<int> { 2 };

        shop.PlaceOrder(user, selectedProducts, quantities);

        Console.WriteLine("Purchase History:");
        foreach (Order order in user.PurchaseHistory)
        {
            Console.WriteLine($"Order Status: {order.Status}, Total Price: {order.TotalPrice:C2}");
            Console.WriteLine("Products:");
            for (int i = 0; i < order.Products.Count; i++)
            {
                Console.WriteLine($"{order.Products[i].Name} - Quantity: {order.Quantities[i]}");
            }
            Console.WriteLine();
        }
    }
}