using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Location
    {
        [Required]
        public required string Province { get; set; }

        [Required]
        public required string City { get; set; }
    }
}
