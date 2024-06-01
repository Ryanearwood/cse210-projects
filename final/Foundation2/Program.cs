
class Program
{
    static void Main(string[] args)
    {
        var order1 = new Order
        {
            Customer = new Customer
            {
                Name = "Ryan Earwood",
                Address = new Address
                {
                    StreetAddress = "555 Main St",
                    City = "Harrisonburg",
                    StateProvince = "VA",
                    Country = "USA"
                }
            },
            Products = new List<Product>
            {
                new Product { Name = "Widget", ProductId = 1, Price = 19.99m, Quantity = 3 },
                new Product { Name = "Gadget", ProductId = 2, Price = 29.99m, Quantity = 2 }
            }
        };

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("Total Price: $" + order1.TotalCost());

      
    }
}
