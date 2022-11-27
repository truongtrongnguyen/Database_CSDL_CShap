using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent_API_Entity_FrameWrok;
//[Table("Product")]
public class Product
{
    //[Key]
    public int ProductID {get; set;}
    [Required]
    [StringLength(50)]
    [Column("Tensanpham", TypeName ="nvarchar")]
    public string? Name {get; set;}
    [Column(TypeName ="money")]
    public decimal Price {get; set;}
    [Required]
    
    public int CateID {get; set;}
    //[ForeignKey("CateID")]
    public virtual Category? Category {get; set;}

    public int? CateID2 {get; set;}
    // [Required]
    // [InverseProperty("ListProducts")]
    public virtual Category? Category2 {get;set;}
}