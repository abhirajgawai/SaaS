using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models;

[Table("Product", Schema = "dbo")]
public class EntityProduct
{
    [Key]
    public int ProductId { get; set; }
    [Required]
    public string ProductName { get; set; } = string.Empty;
    [Required]
    public decimal Price { get; set; }
    [Required]
    public DateTime CreatedDate { get; set; }
    [DefaultValue(false)]
    public bool IsArchived { get; set; }
    [DefaultValue(false)]
    public bool IsFeatured { get; set; }

    [Required]
    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    [Required]
    [ForeignKey("Billboard")]
    public int BillboardId { get; set; }
    [Required]
    [ForeignKey("Size")]
    public int SizeId { get; set; }
    [Required]
    [ForeignKey("Colors")]
    public int ColorId { get; set; }

    public virtual EntityCategory Category { get; set; }
    public virtual EntityBillboard Billboard { get; set; }
    public virtual EntitySize Size { get; set; }
    public virtual EntityColors Color { get; set; }

}