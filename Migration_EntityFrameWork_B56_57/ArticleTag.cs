using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Migration_Scaffold_in_EntityFrameWork_B56_57;

public class ArticleTag
{
    [Key]
    public int ArticleTagID {get; set;}
    public int TagID {get; set;}    //FK
    [ForeignKey("TagID")]
    public Tag Tag {get; set;}
    public int ArticleID {get; set;}    //FK
    [ForeignKey("ArticleID")]
    public Article Article {get; set;}


}