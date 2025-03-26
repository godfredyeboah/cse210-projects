using System;
using System.Collections.Generic;

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Creating addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Creating customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Emily Smith", address2);

        // Creating orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Adding products to order 1
        order1.AddProduct(new Product("Laptop", "L123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M456", 25.50, 2));

        // Adding products to order 2
        order2.AddProduct(new Product("Phone", "P789", 699.99, 1));
        order2.AddProduct(new Product("Charger", "C101", 19.99, 2));
        order2.AddProduct(new Product("Headphones", "H202", 49.99, 1));

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
