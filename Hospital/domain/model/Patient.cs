using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class Patient : Person
    {
        public required HealthInsurance Seguro { get; set; }
        public required string Gender { get; set; }
        public required Contact EmergencyContact { get; set; }
    }
}
