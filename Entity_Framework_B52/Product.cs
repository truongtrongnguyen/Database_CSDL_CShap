using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADO_Entity_Framework;

[Table("Products")]
public class Product
{
    [Key]   // Thiết lập key tự động tăng indext
    public int ProductID { get; set; }

    [Required]
    [StringLength(50)]
    [Column("Tensanpham", TypeName = "nText")]
    public string? Name { get; set; }

    [Column(TypeName = "money")]
    public decimal Price {get; set;}
    [Required]
    public int CateID{get; set;}
    //Tạo Foreign Key
    [ForeignKey("CateID")]
    public virtual Category? Category {get; set;}

    public int? CateID2 {get; set;}
    [ForeignKey("CateID2")]
    [InverseProperty("ListProduct")]    // Điều hướng nghịch, để cho nó liên kết đến category
    public virtual Category Category2 {get; set;}
    public void PrintProductInfo()=> Console.WriteLine($"{ProductID} - {Name} - {Price}");
}

/*
    Table("TableName")
    [Key] --> Primary key(PK)
    [Required]  --> not null
    [StringLength (50)] --> string --> nvarchar
    [Column("TenSanPham", TypeName = "nText)]
    Dấu chấm hỏi là cho phép nó được mang giá trị null
    References Navigation  --> FK - PK CategogyID
    Collection Navigation   --> Lấy ra danh sách các sản phẩm thuộc Category đó
*/