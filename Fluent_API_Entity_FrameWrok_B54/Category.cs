using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent_API_Entity_FrameWrok;
[Table("Category")]
public class Category
{
    [Required]
    public int CategoryID {get; set;}
    [StringLength(50)]
    [Required]
    public string? Name {get; set;}
    [Column(TypeName ="ntext")]
    public string? Description {get; set;}
    public CategoryDetail CategoryDetail {get; set;}
    public virtual List<Product>? ListProduct {get; set;}
    
}