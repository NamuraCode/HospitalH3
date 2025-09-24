using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class User
    {
        public required string Role { get; set; }
        public required string NameUser { get; set; }
        public required string Password { get; set; }
    }
}
