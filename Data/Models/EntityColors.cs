using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models;

[Table("Color", Schema = "dbo")]
public class EntityColors
{
    [Key]
    public int ColorId { get; set; }
    [Required]
    public string ColorName { get; set; } = string.Empty;
    [Required]
    public string HexCode { get; set; } = string.Empty;
    [Required]
    public DateTime CreatedDate { get; set; }
}
