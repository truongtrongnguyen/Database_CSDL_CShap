using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;

namespace Fluent_API_Entity_FrameWrok;

public class ShopContext:DbContext
{
    // Sử dụng ILoggerFactory để khi query thì nó sẽ tạo ra lệnh chạy dưới SqlServer
    public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create((ILoggingBuilder builder) =>{
        builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
        //builder.AddFilter(DbLoggerCategory.Database.Name, LogLevel.Information);
        builder.AddConsole();
    });

      // khai báo một bảng chứa các product
    public DbSet<Category>? categories {get;set;} 
    public DbSet<Product>? Products {set; get;}    

    private string connectionString = @"server=DESKTOP-OJA04UG\SQLEXPRESS; database=TestData; UID=sa;
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         base.OnModelCreating(modelBuilder);
        // Gọi Fluent API, phương thức này được gọi sau khi OnConfiguring gọi xong
        /*
        Cách 1:
        var entity = modelBuilder.Entity(typeof(Product));
        // Sử dụng entity. để gọi API cho các Model của Product
        Cách 2:
         var entity = modelBuilder.Entity<Product>();
        entity.
        // Cách 3: 
       modelBuilder.Entity<Product>(entity =>{

       });
        */
        modelBuilder.Entity<Product>((EntityTypeBuilder<Product> entity) =>{
            // Table Mapping ánh xạ xuống CSDL, cho nên không cần dùng attibute
            entity.ToTable("SanPham");

            // Khóa chính PK
            entity.HasKey(p => p.ProductID);

            //Index
            entity.HasIndex(p => p.Price).HasDatabaseName("index_sapham_price");

            // Relative Mối quan hệ 1 nhiều 
            entity.HasOne(p => p.Category).WithMany()   // Thuộc tính WithMany không có parameter là nó không có danh sách sản phẩm
            .HasForeignKey("CateID")                    // Dặt tên FK
            .OnDelete(DeleteBehavior.Cascade)           // Xóa phần 1 thì phần nhiều bị xóa theo
            .HasConstraintName("KhoaNgoai_SanPham__Category");  // Đặt tên cho Khóa Ngoại          

            entity.HasOne(p => p.Category2)
            .WithMany(c => c.ListProduct)
            .HasForeignKey("CateID2")
            .OnDelete(DeleteBehavior.NoAction);

            entity.Property(p => p.Name)
            .HasColumnName("Title")
            .HasColumnType("nvarchar")
            .HasMaxLength(50)
            .IsRequired(false)
            .HasDefaultValue("item");

            entity.Property(p => p.Price)
            .HasColumnName("GiaSanPham")
            .HasColumnType("money");
        });
      // Thiết lập mối quan hệ 1-1, Khi thêm dữ liệu thì ta phải thêm table Category trước
      modelBuilder.Entity<CategoryDetail> (entity=>
      entity.HasOne(d => d.Category)
      .WithOne(c => c.CategoryDetail)
      .HasForeignKey<CategoryDetail>(c => c.CategoryDetailID) //Khóa ngoại
      .OnDelete(DeleteBehavior.Cascade));
    }
}