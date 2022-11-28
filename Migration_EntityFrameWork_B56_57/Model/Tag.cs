using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Migration_Scaffold_in_EntityFrameWork_B56_57;

public class Tag
{
    // [Key]
    // //[StringLength(20)]
    // public string TagID {get; set;}
    [Column(TypeName = "ntext")]
    public string? Content {get; set;}
    [Key]
    public int TagID {get; set;}
}