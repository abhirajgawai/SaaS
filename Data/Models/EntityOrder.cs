using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models;

[Table("Order", Schema = "dbo")]
public class EntityOrder
{
    [Key]
    public int OrderId { get; set; }
    [Required]
    public int ProductId { get; set; }
    [Required]
    public string Address { get; set; } = string.Empty;
    [Required]
    public bool Paid { get; set; }
    [Required]
    public DateTime CreatedDate { get; set; }
}
