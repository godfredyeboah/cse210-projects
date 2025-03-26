using System;
using System.Collections.Generic;

// Address class to store customer address details
class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    // Method to get the full address as a string
    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}

// Customer class to store customer details
class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    // Method to get customer name
    public string GetName()
    {
        return name;
    }

    // Method to get the customer's address
    public string GetAddress()
    {
        return address.GetFullAddress();
    }
}

// Product class to store product details
class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to get total cost of the product
    public double GetTotalCost()
    {
        return price * quantity;
    }

    // Method to get product details for packing label
    public string GetPackingLabel()
    {
        return $"{name} (ID: {productId})";
    }
}

// Order class to store the order details
class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to calculate total order price (includes shipping)
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        // Shipping cost: $5 for USA, $35 for non-USA
        double shippingCost = customer.LivesInUSA() ? 5.0 : 35.0;
        return total + shippingCost;
    }

    // Method to get the packing label (list of products)
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += "- " + product.GetPackingLabel() + "\n";
        }
        return label;
    }

    // Method to get the shipping label (customer details)
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress()}";
    }
}

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
