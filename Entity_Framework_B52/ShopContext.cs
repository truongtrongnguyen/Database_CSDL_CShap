using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ADO_Entity_Framework;
// Lớp biểu diễn một cơ sở dữ liệu
public class ShopContext:DbContext
{
    // Sử dụng ILoggerFactory để khi query thì nó sẽ tạo ra lệnh chạy dưới SqlServer
    public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>{
        builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
        //builder.AddFilter(DbLoggerCategory.Database.Name, LogLevel.Information);
        builder.AddConsole();
    });

      // khai báo một bảng chứa các product
    public DbSet<Category>? categories {get;set;} 
    public DbSet<Product>? Products {set; get;}    

    private string connectionString = @"server=DESKTOP-OJA04UG\SQLEXPRESS; database=shopdate; UID=sa;
                                    Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";

    // Phương thức này được chạy khi một đối tượng DbContext được tạo ra
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseLoggerFactory(loggerFactory);
        optionsBuilder.UseSqlServer(connectionString);  // Gọi phương thức này để làm việc với Sql
        //optionsBuilder.UseLazyLoadingProxies();     //  thuộc tính tham chiếu tự động load khi nó được truy cập
        // Cần khai báo các thuộc tính có thêm virtual, nhược điểm là code chạy nặng
    }
}