using Model.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class UserDto
    {

        public required string Email { get; set; }

        public required string Name { get; set; }

        public int? Age { get; set; }

        public Gender Gender { get; set; }

        public required Location Location { get; set; }
    }
}
