using System;

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