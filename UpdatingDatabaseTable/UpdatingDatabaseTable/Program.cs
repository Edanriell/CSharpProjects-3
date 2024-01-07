using UpdatingDatabaseTable;

var service = new GlobalFactoryService(new FactoryDbContext());

service.CreateManufacturersInUsa(new[] { "Best Buy", "Iron Retail" });
service.CreateUsaProducts(
    new[]
    {
        new Product { Name = "Toy computer", Price = 20.99m },
        new Product { Name = "Loli microphone", Price = 7.51m }
    }
);
service.SetAnyUsaProductOnDiscount(5);
service.RemoveAnyProductInUsa();

var manufacturers = service.GetManufacturersInUsa();

foreach (var manufacturer in manufacturers)
{
    Console.WriteLine($"{manufacturer.Name}:");
    foreach (var product in manufacturer.Products)
    {
        Console.WriteLine($"{product.Name} {product.Price}");
    }
}
