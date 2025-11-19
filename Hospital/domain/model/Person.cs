using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    public class Person
    {
        public required string Name { get; set; }
        public required ulong Id { get; set; }
        public required string Email { get; set; }
        public required ulong Document { get; set; }
        public required int Phone { get; set; }
        public required DateTime DateBirth { get; set; }
        public required string Direction { get; set; }
        public required Contact EmergencyContact { get; set; }
    }
}
