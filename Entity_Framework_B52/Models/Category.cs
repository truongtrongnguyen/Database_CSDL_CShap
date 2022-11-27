// Là một bảng biểu diễn danh mục các sản phẩm
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADO_Entity_Framework;
[Table("Category")]
public class Category
{
    [Key]
    public int CategoryID {get; set;}
    [Required]
    [StringLength(100)]
    public string? Name {get; set;}

    [Column(TypeName = "ntext")]
    public string? Description{get; set;}

    public virtual  List<Product>? ListProduct{get; set;}
}   