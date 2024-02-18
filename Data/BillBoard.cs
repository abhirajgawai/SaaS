using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BillBoard
    {
        [Key]
        [Required]
        public int BillBoardId { get; set; }

        [ForeignKey("ProductId")]
        public string ProductId { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public Guid ImageId { get; set;  }= Guid.Empty;
    }
}
