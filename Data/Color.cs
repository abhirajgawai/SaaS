using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Color
    {
        [Key]
        [Required]
        public int ColorId { get; set; } = 0;
    
        public string ColorName { get; set; } = string.Empty;

        [Required]
        public string HexCode { get; set; } = string.Empty;

    }
}
