using System.Security.AccessControl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sql;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ADO_Entity_Framework;
class Program
{
    static void Main(string[] args)
    {
        // CreateDatabase();
         //DropDatabase();
        //InsertInto();
       // SelectInfo();
        Update(4, "samsung");
        //Delete(3);
        Console.WriteLine("Hello, World!");
    }
    static void CreateDatabase()    
    {
        using var dbContext = new ProductDbContext();
        string dbName = dbContext.Database.GetDbConnection().Database;
        //Console.WriteLine(dbName);

        var isKq = dbContext.Database.EnsureCreated(); // Kiểm tra Database chưa có CSDL, hoặc các table thì nó sẽ tạo mới, trả về true/false
        if(isKq)
        {
            Console.WriteLine($"Tao {dbName} thanh cong");
        }
        else{
            Console.WriteLine($"Datavase {dbName} da ton tai");
        }
    }

    static void DropDatabase()
    {
        using var dbContext = new ProductDbContext();
        var isKq = dbContext.Database.EnsureDeleted();
          if(isKq)
        {
            Console.WriteLine($"Xoa Databse thanh cong");
        }
        else{
            Console.WriteLine($"Xoa Database that bai");
        }
    }

    static void InsertInto()
    {
        using var dbContext = new ProductDbContext();
        /*
            Models (Product)
            Add hoặc AddAsync
            SaveChange hoặc SaveChangedAsync
        */
        var products = new Product[]{
        new Product(){ProductName = "San pham 3", ProVider = "Cont ty 3"},
        new Product(){ProductName = "San pham 4", ProVider = "Cong ty 4"},
        new Product(){ProductName = "San pham 5", ProVider = "Cong ty 5"}
        };
        dbContext.AddRange(products);

        var sodong = dbContext.SaveChanges();   //luôn luôn gọi, Và nó trả về số dòng bị tác động
        Console.WriteLine("So dong da chen la: "+ sodong);
    }

    static void SelectInfo()
    {
         using var dbContext = new ProductDbContext();

        // var products = dbContext.Products.ToList();
        // products.ForEach(product => product.PrintProductInfo());

        // var result = from product in dbContext.Products
        //                 where product.ProVider.Contains("ty")
        //                 orderby product.ProductID descending
        //                 select product;
        // result.ToList().ForEach(Product => Product.PrintProductInfo());

        var kq = (from product in dbContext.Products
                where product.ProductID == 4
                select product).FirstOrDefault();
                kq.PrintProductInfo();
    }

    static void Update(int id, string name)
    {
        using var dbContext = new ProductDbContext();
        var kq = (from product in dbContext.Products
                where product.ProductID == id
                select product).FirstOrDefault();
        if(kq!=null)
        {
            // Đối tượng theo dõi sự thay đổi của Product được tích hợp trong dbContext
            EntityEntry<Product> entry = dbContext.Entry(kq);
            entry.State = EntityState.Detached; // (Loại bỏ) Dữ liệu không được cập nhật

            kq.ProductName = name;
            var sodong = dbContext.SaveChanges();
            Console.WriteLine($"Update {sodong} row");
        }
    }

    static void Delete(int id)
    {
        using var dbContext = new ProductDbContext();
        var product = (from p in dbContext.Products
                        where p.ProductID == id
                        select p).FirstOrDefault();
        if(product != null)
        {
            dbContext.Remove(product);
            var row = dbContext.SaveChanges();
            Console.WriteLine($"Delete {row} row");
        }
    }
}   
