using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class VitalStatistics
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public int SystolicPressure { get; set; }
        public int DiastolicPressure { get; set; }
        public int HeartRate { get; set; }
        public double Temperature { get; set; }
    }
}
