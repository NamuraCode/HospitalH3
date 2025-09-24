using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.ports
{
    internal interface InvoicePorts
    {
        public void GenerateInvoice()
        {
            // generar factura
        }
        public void SendInvoice()
        {
            // enviar factura
        }
        public void GetInvoiceByIdUser()
        {
            // obtener detalles de la factura por id de usuario
        }
    }
}
