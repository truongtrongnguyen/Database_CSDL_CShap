using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Migration_Scaffold_in_EntityFrameWork_B56_57;
[Table("Article")]
public class Article
{
    [Key]
    public int ArticleID {get; set;}
    [StringLength(50)]
    public string? Name {get; set;}
    [Column(TypeName ="nvarchar")]
    public string? Content {get; set;}
}