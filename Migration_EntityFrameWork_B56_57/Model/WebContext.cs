using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Migration_Scaffold_in_EntityFrameWork_B56_57;

public class WebContext: DbContext
{
    public DbSet<Article>? Articles {get; set;}
    public DbSet<Tag>? Tags {get; set;}
    public DbSet<ArticleTag> ArticleTag {get; set;}
    
    private string connect = @"server=DESKTOP-OJA04UG\SQLEXPRESS; database= webdb; UID=sa;
                     Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";
    
    public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>{
    builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
    builder.AddConsole();
    });

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        base.OnConfiguring(optionBuilder);
        optionBuilder.UseLoggerFactory(loggerFactory);
        optionBuilder.UseSqlServer(connect);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ArticleTag>(entity =>{  // Tạo index trên nhiều thuộc tính
            entity.HasIndex(article => new {article.ArticleID, article.TagID})
            .IsUnique();
        });
    }
}