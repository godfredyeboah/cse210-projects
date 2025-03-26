using System;

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