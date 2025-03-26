using System;

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