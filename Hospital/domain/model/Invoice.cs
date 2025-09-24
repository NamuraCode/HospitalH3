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
        public required string Diagnosis { get; set; }
        public required int Price { get; set; }
    }
}
