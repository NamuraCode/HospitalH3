using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class Procedure
    {
        public required int IdProcedure { get; set; }
        public required int Quantity { get; set; }
        public required int frequency { get; set; }

    }
}
