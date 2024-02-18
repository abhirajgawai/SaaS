using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ClientDetails
    {
        [Required]
        public string ClientName { get; set; } = string.Empty;

        public string ClientPhoneNumber { get; set; } = string.Empty;

        public string ClientPaymentMode { get; set; }= string.Empty;

        public string ClientAddressDetails { get; set; } = string.Empty;
    }
}
