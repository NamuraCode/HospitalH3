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
        public Patient Patient { get; set; }
        public User Doctor { get; set; }
        public string Diagnosis { get; set; }

        public int Price { get; set; }
    }
}
