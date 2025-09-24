using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class RecordMedical
    {
        public required Patient Patient { get; set; }
        public required User Doctor { get; set; }
        public required int Quantity { get; set; }
    }
}
