using Microsoft.EntityFrameworkCore;

namespace Fluent_API_Entity_FrameWrok;
class Program
{
    static void Main(string[] args)
    {
        DropDatabase();
        CreateDatabase();
        Console.WriteLine("Hello, World!");
    }
    static void CreateDatabase()
    {
        using var dbContext = new ShopContext();
        string dbName = dbContext.Database.GetDbConnection().Database;
        var check = dbContext.Database.EnsureCreated();
        if(check)
            Console.WriteLine($"Create Database {dbName} successful");
        else
            Console.WriteLine($"Create Database {dbName} faild");
    }
    static void DropDatabase()
    {
        var dbContext = new ShopContext();
        string dbName = dbContext.Database.GetDbConnection().Database;
        var check = dbContext.Database.EnsureDeleted();
        if(check)
            Console.WriteLine($"Delete Database {dbName} successful");
        else
            Console.WriteLine($"Delete Database {dbName} faild");

    }
}
