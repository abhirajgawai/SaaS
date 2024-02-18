using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Size
    {
        [Key]
        [Required]
        public int SizeId { get; set; } = 0;

        public string SizeDisplayName { get; set; } = string.Empty;

        [Required]
        public string SizeDisplayValue { get; set; } = string.Empty;
    }
}
