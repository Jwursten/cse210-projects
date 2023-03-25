using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address canadaAddress = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        Customer usaCustomer = new Customer("John Smith", usaAddress);
        Customer canadaCustomer = new Customer("Jane Doe", canadaAddress);

        Product product1 = new Product("Product 1", "p1", 9.99m, 2);
        Product product2 = new Product("Product 2", "p2", 19.99m, 1);
        Product product3 = new Product("Product 3", "p3", 4.99m, 5);

        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(canadaCustomer);
        order2.AddProduct(product1);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: {order1.CalculateTotalCost():C}");

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: {order2.CalculateTotalCost():C}");
    }
}