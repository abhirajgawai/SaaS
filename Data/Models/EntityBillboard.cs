using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models;

[Table("Billboard", Schema = "dbo")]
public class EntityBillboard
{
    [Key]
    public int BillboardId { get; set; }
    [Required]
    public string BillboardName { get; set; } = string.Empty;
    [Required]
    public DateTime CreatedDate { get; set; }
}