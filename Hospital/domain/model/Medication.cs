using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class Medication
    {
        public required string NameMedication { get; set; }
        public required string Dose { get; set; }
    }
}
