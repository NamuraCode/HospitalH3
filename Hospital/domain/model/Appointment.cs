using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class Appointment
    {
        public required Patient Patient { get; set; }
        public required User Doctor { get; set; }
        public required Procedure Procedure { get; set; }
        public required Order Order { get; set; }
        public required VitalStatistics VitalStatistics { get; set; }
        public required string Observations { get; set; }
    }
}
