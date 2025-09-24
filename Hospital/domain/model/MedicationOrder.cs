using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class MedicationOrder : Item
    {
        public required Medication Medicamento { get; set; }
        public required int Quantity { get; set; }
    }
}
