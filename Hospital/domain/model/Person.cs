using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class Person
    {   
        public required string Name { get; set; }
        public required string Id { get; set; }
        public required string Email{ get; set; }
        public required string Phone { get; set; }
    }
}
