using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinantialOrganizationAPI_ASP.NetCore.Models
{
    public class Financial
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Value { get; set; }

        public DateTime Date { get; set; }
    }
}