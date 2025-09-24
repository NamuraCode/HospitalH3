using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.domain.model;

namespace Hospital.domain.model
{
    internal class Invoice
    {
        public required Patient Patient { get; set; }
        public required User Doctor { get; set; }
        public required HealthInsurance HealthInsurance { get; set; }
        public required string Diagnostic { get; set; }
        public required List<MedicationOrder> MedicationOrder { get; set; }
        public required List<Procedure> Procedures { get; set; }
        public required List<DiagnosticAssistance> DiagnosticAssistance { get; set; }
        public required decimal TotalAmount { get; set; }
    }
}
