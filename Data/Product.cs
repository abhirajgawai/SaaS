using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Product
    {

        [Key]
        [Required]
    
        public Guid ProductId { get; set; }

        [Required]
        public string ProductName { get; set; } = string.Empty;

        public string Description { get; set; }= string.Empty;

        public double ProductPrice { get; set; }

        public string ProductSize { get; set; }=string.Empty;

        public bool IsArchived { get; set; } = false;

        public bool IsFeatured { get; set; } = false;

        public bool IsDeleted { get; set; } = false;

        [ForeignKey("BillBoardId")]
        public int BillBoardId { get; set; }


        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        [AllowNull]
        public List<Color> ProductColor { get; set; }

    }
}
