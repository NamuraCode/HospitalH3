using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    public class Contact
    {
        public required ulong Id { get; set; }
        public required string Relation { get; set; }
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
