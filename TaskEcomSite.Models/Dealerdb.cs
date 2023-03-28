using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEcomSite.Models
{
    public class Dealerdb
    {
        public string Name { get; set; }
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public Status Status { get; set; }
        public string? Reason { get; set; }
    }
}
