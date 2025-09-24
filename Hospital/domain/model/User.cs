using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class User : Person
    {
        public string Role { get; set; }
        public string NameUser { get; set; }
        public string Password { get; set; }
    }
}
