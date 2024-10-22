using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Balite St.", "Tantangan", "South Cotabato", "Philippines");
        Address address2 = new Address("94 N 400 W St.", "North Salt Lake", "UT", "USA");

        // Create customer objects
        Customer customer1 = new Customer("Max Padua", address1);
        Customer customer2 = new Customer("Jeanine Rottacher", address2);

        // Create product objects
        Product product1 = new Product("IPhone", "IP0001", 131.5m, 2);
        Product product2 = new Product("Speaker", "S0257", 154.99m, 4);
        Product product3 = new Product("Refrigerator", "R1303", 1057.99m, 1);
        Product product4 = new Product("Headphone", "H9599", 99.59m, 2);

        // Create order objects and add products to orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display results for order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost():0.00}\n");

        // Display results for order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost():0.00}");
    }
}