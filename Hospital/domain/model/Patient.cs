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
        public int Id { get; set; }
        public HealthInsurance Seguro { get; set; }
        public string Gender { get; set; }
        public Contact EmergencyContact { get; set; }
    }
}
