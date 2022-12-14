// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Migration_Scaffold_in_EntityFrameWork_B56_57;

#nullable disable

namespace MigrationScaffoldinEntityFrameWorkB5657.Migrations
{
    [DbContext(typeof(WebContext))]
    [Migration("20221128040349_V4")]
    partial class V4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Migration_Scaffold_in_EntityFrameWork_B56_57.Article", b =>
                {
                    b.Property<int>("ArticleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleID"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ArticleID");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("Migration_Scaffold_in_EntityFrameWork_B56_57.ArticleTag", b =>
                {
                    b.Property<int>("ArticleTagID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleTagID"));

                    b.Property<int>("ArticleID")
                        .HasColumnType("int");

                    b.Property<int>("TagID")
                        .HasColumnType("int");

                    b.HasKey("ArticleTagID");

                    b.HasIndex("TagID");

                    b.HasIndex("ArticleID", "TagID")
                        .IsUnique();

                    b.ToTable("ArticleTag");
                });

            modelBuilder.Entity("Migration_Scaffold_in_EntityFrameWork_B56_57.Tag", b =>
                {
                    b.Property<int>("TagID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagID"));

                    b.Property<string>("Content")
                        .HasColumnType("ntext");

                    b.HasKey("TagID");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Migration_Scaffold_in_EntityFrameWork_B56_57.ArticleTag", b =>
                {
                    b.HasOne("Migration_Scaffold_in_EntityFrameWork_B56_57.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Migration_Scaffold_in_EntityFrameWork_B56_57.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Tag");
                });
#pragma warning restore 612, 618
        }
    }
}
