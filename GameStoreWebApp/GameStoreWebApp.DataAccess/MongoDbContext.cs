using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.DataAccess.Settings;
using MongoDB.Driver;

namespace GameStoreWebApp.DataAccess;

public class MongoDbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext(MongoDbSettings settings)
    {
        var client = new MongoClient(settings.ConnectionString);
        _database = client.GetDatabase(settings.DatabaseName);
    }

    public IMongoCollection<Game> Games => _database.GetCollection<Game>("games");

    public IMongoCollection<Category> Categories => _database.GetCollection<Category>("categories");

    public IMongoCollection<Customer> Customers => _database.GetCollection<Customer>("customers");

    public IMongoCollection<Employee> Employees => _database.GetCollection<Employee>("employees");

    public IMongoCollection<Order> Orders => _database.GetCollection<Order>("orders");

    public IMongoCollection<OrderDetail> OrderDetails => _database.GetCollection<OrderDetail>("order-details");

    public IMongoCollection<Product> Products => _database.GetCollection<Product>("products");

    public IMongoCollection<Region> Regions => _database.GetCollection<Region>("regions");
    public IMongoCollection<Shipper> Shippers => _database.GetCollection<Shipper>("shippers");

    public IMongoCollection<Supplier> Suppliers => _database.GetCollection<Supplier>("suppliers");

    public IMongoCollection<Territory> Territories => _database.GetCollection<Territory>("territories");

    public IMongoCollection<EmployeeTerritory> EmployeeTerritories => _database.GetCollection<EmployeeTerritory>("employee-territories");

}
