using System.Security.AccessControl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sql;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ADO_Entity_Framework;
class Program
{
    static void Main(string[] args)
    {
    //     DropDatabase();
    //    CreateDatabase();
    //      InsertData();
        using var dbContext = new ShopContext();

        // var p1 = dbContext.Products.Find(6);    // Tìm sản phẩm theo key
        // p1.PrintProductInfo();

        // Lấy ra sản phẩm có chứa 'i' và sắp xếp giảm dần theo giá
        // var p2 = from p in dbContext.Products 
        //         where p.Name.Contains("i")
        //         orderby  p.Price descending 
        //         select p ;
        // // Khi ta thực hiện lấy ra dữ liệu thì lúc này nó mới connect tới Database
        // p2.Take(2).ToList().ForEach(p => p.PrintProductInfo());


        var p2 = from p in dbContext.Products
                join c in dbContext.categories
                on p.CateID equals c.CategoryID
                select new 
                {
                    Ten = p.Name,
                    DanhMuc = c.Name,
                    Gia = p.Price
                };
        p2.ToList().ForEach(p =>Console.WriteLine(p) );

        // Xóa một Category,  Khi xóa thì các product có liên kết với category cũng sẽ bị xóa theo
        //  var category1 = (from p in dbContext.categories where p.CategoryID ==2 select p).FirstOrDefault();
        // dbContext.Remove(category1);   
        //  dbContext.SaveChanges();    

        // Console.WriteLine($"{category1.Name} - {category1.Description}");

        // khi thực hiện UseLazyLoadingProxies thì ta không cần load thủ công như bên dưới nên đóng comment lại
        // var entry = dbContext.Entry(category1);
        // entry.Collection(e => e.ListProduct).Load();

        // if(category1.ListProduct != null)
        // {
        //     Console.WriteLine("So san pham la: "+ category1.ListProduct.Count);
        //     category1.ListProduct.ForEach(c => c.PrintProductInfo());
        // }
        // else{
        //     Console.WriteLine("Danh sach san pham == null");
        // }

        #region    SỬ DỤNG JOIN GIỐNG TRONG SQL
        // var product =  (from p in dbContext.Products where p.ProductID ==3 select p).FirstOrDefault();
        // product.PrintProductInfo();
        // var e = dbContext.Entry(product);  // Lấy đối tượng Entry theo dõi sự thay đổi của product
        // e.Reference(p => p.Category).Load();
        // if(product.Category != null)
        // {
        //    Console.WriteLine($"{product.Category.Name} - {product.Category.Description}");
        // }
        // else
        // {
        //    Console.WriteLine("Category == null");
        // }
        #endregion

        Console.WriteLine("Hello, World!");
    }
    static void CreateDatabase()    
    {
        using var dbContext = new ShopContext();
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
        using var dbContext = new ShopContext();
        var isKq = dbContext.Database.EnsureDeleted();
          if(isKq)
        {
            Console.WriteLine($"Xoa Databse thanh cong");
        }
        else{
            Console.WriteLine($"Xoa Database that bai");
        }
    }

   static void InsertData()
   {
    using  var dbContext = new ShopContext();

    var c1 = new Category(){Name = "Dien Thoai", Description  = "Cac loai dien thoai"};
    var c2 = new Category() {Name = "Do uong", Description = "Cac loai do uong"};
    dbContext.categories.Add(c1);
    dbContext.categories.Add(c2);

    // var ca1 = (from c in dbContext.categories where c.CategoryID ==1 select c.CategoryID).FirstOrDefault();
    // var ca2 = (from c in dbContext.categories where c.CategoryID ==2 select c.CategoryID).FirstOrDefault();

    ////Có thể thiết lập CateID bằng số hoặc thông qua truy vấn Linq
    dbContext.Add(new Product(){Name = "IPhone 8", Price = 1000, CateID = 1});  
    dbContext.Add(new Product() {Name = "SamSung", Price = 800, CateID = 1});
    dbContext.Add(new Product() {Name = "Ruou vang", Price = 500, CateID = 2});
    dbContext.Add(new Product() {Name = "Cafe", Price = 100, CateID = 2});
    dbContext.Add(new Product() {Name = "Bia", Price = 200, CateID = 2});
    dbContext.Add(new Product() {Name = "Coca cola", Price = 100, CateID = 2});
    dbContext.Add(new Product() {Name = "Pesi", Price = 300, CateID = 2});


    var row = dbContext.SaveChanges();
    Console.WriteLine($"Insert {row} row");
   }
}   
