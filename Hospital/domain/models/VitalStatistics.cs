using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class VitalStatistics
    {
        public required double Weight { get; set; }
        public required double Height { get; set; }
        public required int SystolicPressure { get; set; }
        public required int DiastolicPressure { get; set; }
        public required int HeartRate { get; set; }
        public required double Temperature { get; set; }
        public required int BloodOxygenLevel { get; set; }
    }
}
