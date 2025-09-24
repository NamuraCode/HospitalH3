using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class HealthInsurance
    {
        public required string Name { get; set; }
        public required string NumberPolicy { get; set; }
        public required bool StatusPolicy { get; set; }
        public required int Discount { get; set; }
        public required DateTime ValidityPolicy { get; set; }
    }
}
