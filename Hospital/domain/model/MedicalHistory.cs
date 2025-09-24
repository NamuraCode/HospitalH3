using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class MedicalHistory : Appointment
    {
        public required string Observations { get; set; }
        public required string Diagnostic { get; set; }
        public required List<MedicationOrder>? MedicationOrder { get; set; }
        public required List<ProcedureOrder>? Procedures { get; set; }
        public required List<DiagnosticAssistance>? DiagnosticAssistance { get; set; }
        public required Invoice? Invoice { get; set; }
    }
}
