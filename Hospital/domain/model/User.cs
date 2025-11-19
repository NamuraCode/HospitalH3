using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Hospital.domain.model
{
    public class User : Person
    {
        public required string Role { get; set; }
        public required string NameUser { get; set; }
        public required string Password { get; set; }

    }
}
