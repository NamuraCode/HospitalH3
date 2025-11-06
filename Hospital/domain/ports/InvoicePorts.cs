using Hospital.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.ports
{
    internal interface InvoicePorts
    {
        public void GenerateInvoice(Invoice invoice)
        {
            // genera factura
        }
        public void SendInvoice()
        {
            // envia factura
        }
        public List<Invoice> GetInvoicesByIdUser(ulong userId)
        {
            // reemplazar por la de la base de datos
            return new List<Invoice>();
        }
    }
}
