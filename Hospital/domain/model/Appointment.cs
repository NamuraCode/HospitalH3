using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class Appointment
    {
        public Patient Patient { get; set; }
        public User Doctor { get; set; }
        public Procedure Procedure { get; set; }
        public Order Order { get; set; }
        public VitalStatistics VitalStatistics { get; set; }
        public string Observations { get; set; }
    }
}
