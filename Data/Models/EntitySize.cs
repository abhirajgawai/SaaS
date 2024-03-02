using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Data.Models;

[Table("Size", Schema = "dbo")]
public class EntitySize
{
    [Key]
    public int SizeId { get; set; }
    [Required]
    public string Size { get; set; } = string.Empty;
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public DateTime CreatedDate { get; set; }
}
