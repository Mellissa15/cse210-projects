using System;

class Program
{
    static void Main(string[] args)
    {

        // Create addresses
        Address addr1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Address addr2 = new Address("456 Elm Rd", "Toronto", "ON", "Canada");

        // Create customers
        Customer cust1 = new Customer("John Doe", addr1);
        Customer cust2 = new Customer("Jane Smith", addr2);

        // Create products
        Product p1 = new Product("Laptop", "LTP123", 799.99, 1);
        Product p2 = new Product("Wireless Mouse", "MS456", 25.50, 2);
        Product p3 = new Product("USB Cable", "USB789", 10.00, 3);
        Product p4 = new Product("Monitor", "MN345", 150.00, 1);

        // Create first order and add products
        Order order1 = new Order(cust1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        // Create second order and add products
        Order order2 = new Order(cust2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);

        // Display for order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine(new string('-', 40));

        // Display for order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
    }
}