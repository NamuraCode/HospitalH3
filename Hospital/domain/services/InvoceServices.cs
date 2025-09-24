using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.domain.ports;
using Hospital.domain.model;

namespace Hospital.domain.services
{
    internal class InvoceServices
    {
        private InvoicePorts invocePorts;
        private HealthInsurancePorts healthInsurancePorts;
        public void IvoicesTotalAmout(Patient patient) {
            List<Invoice> invoices = invocePorts.GetInvoicesByIdUser(userId: patient.Id);
            if(invoices.Count == 0) {
                throw new Exception("El paciente no tiene facturas.");
            }
            decimal totalAmount = invoices.Sum(invoice => invoice.TotalAmount);

            HealthInsurance healtInsurance = healthInsurancePorts.GetHealthInsuranceByIdPatient(userId: patient.Id);
            if(healtInsurance != null || healtInsurance.StatusPolicy) {
                decimal discount = healtInsurance.Discount;
                decimal discountedAmount = totalAmount - discount;
                if(discountedAmount < 0) {
                    discountedAmount = 0;
                }
                Console.WriteLine($"El monto total de las facturas del paciente {patient.Name} con el descuento aplicado es: {discountedAmount}");
            } else {
                Console.WriteLine($"El monto total de las facturas del paciente {patient.Name} es: {totalAmount}");
            }

        }
    }
}
