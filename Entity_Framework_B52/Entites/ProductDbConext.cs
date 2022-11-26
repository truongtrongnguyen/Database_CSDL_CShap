using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ADO_Entity_Framework;
// Lớp biểu diễn một cơ sở dữ liệu
public class ProductDbContext:DbContext
{
    public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>{
        builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
        //builder.AddFilter(DbLoggerCategory.Database.Name, LogLevel.Information);
        builder.AddConsole();
    });
    public DbSet<Product>? Products {set; get;}      // khai báo một bảng chứa các product
    private string connectionString = @"server=DESKTOP-OJA04UG\SQLEXPRESS; database=data01; UID=sa;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";

    // Phương thức này được chạy khi một đối tượng DbContext được tạo ra
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseLoggerFactory(loggerFactory);
        optionsBuilder.UseSqlServer(connectionString);  // Gọi phương thức này để làm việc với Sql
    }
}