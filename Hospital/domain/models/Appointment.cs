using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.model
{
    internal class Appointment
    {
        public int Id { get; set; }
        public required Patient Patient { get; set; }
        public required User Doctor { get; set; }
        public DateTime DateAdmission { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
