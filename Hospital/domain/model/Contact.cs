using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class Contact : Person
    {
        public required string Relation { get; set; }
    }
}
