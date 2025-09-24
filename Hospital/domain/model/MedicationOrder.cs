using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class MedicationOrder
    {
        public Medication Medicamento { get; set; }
        public int Quantity { get; set; }
    }
}
