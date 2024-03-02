using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models;

[Table("Category", Schema = "dbo")]
public class EntityCategory
{
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string CategoryName { get; set; } = string.Empty;
    [Required]
    public DateTime CreatedDate { get; set; }

    [Required]
    [ForeignKey("Billboard")]
    public int BillboardId { get; set; }

    public virtual EntityBillboard Billboard { get; set; }
}