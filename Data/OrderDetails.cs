using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class OrderDetails
    {
        [Key]
        [Required]

        public int OrderId { get; set; }

        [Required]
        public string OrderUnderName { get; set; } = string.Empty;

        public string OrderDescription { get; set; } = string.Empty;

        public double OrderTotalPrice { get; set; }

        public string OrderAddressDetails { get; set; } = string.Empty;

        public bool IsOrderPaid { get; set; } = false;

        [AllowNull]
        public List<ClientDetails> ClientDetails { get; set; }

    }
}
