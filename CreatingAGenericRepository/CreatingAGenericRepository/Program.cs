using CreatingAGenericRepository;

var db = new FactoryDbContext();

var manufacturersRepository = new Repository<Manufacturer>(db);

var manufacturer = new Manufacturer { Country = "Lithuania", Name = "Tomo" };
var id = manufacturersRepository.Create(manufacturer);

manufacturer.Name = "New Name";
manufacturersRepository.Update(manufacturer);

var manufacturerAfterChanges = manufacturersRepository.Get(id);
Console.WriteLine(
    $"Id: {manufacturerAfterChanges.Id}, " + $"Name: {manufacturerAfterChanges.Name}"
);

var countBeforeDelete = manufacturersRepository.Get().Count();
manufacturersRepository.Delete(id);
var countAfter = manufacturersRepository.Get().Count();
Console.WriteLine($"Before: {countBeforeDelete}, after: {countAfter}");
