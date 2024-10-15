using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class UserSummaryDto
    {
        public required string City { get; set; }
        public required string Gender { get; set; }
        public int TotalCount { get; set; }
    }

}
