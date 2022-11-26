using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADO_Entity_Framework;

[Table("products")]
public class Product
{
    [Key]   // Thiết lập key tự động tăng indext
    public int ProductID { get; set; }
    [Required]
    [StringLength(50)]
    public string? ProductName { get; set; }
    [StringLength(50)]
    public string? ProVider {get; set;}
    public void PrintProductInfo()=> Console.WriteLine($"{ProductID} - {ProductName} - {ProVider}");
}