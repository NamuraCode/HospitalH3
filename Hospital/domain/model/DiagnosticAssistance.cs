using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class DiagnosticAssistance : Order
    {
        public required int IdDiagnosticAssistance { get; set; }
        public required int Quantity { get; set; }
        public required int Frecuency { get; set; }
        public required List<MedicationOrder>? MedicationOrder { get; set; }
        public required List<ProcedureOrder>? Procedures { get; set; }
        public required bool SpecialistAssistance { get; set; }
        public User? Specialist { get; set; }
    }

}
