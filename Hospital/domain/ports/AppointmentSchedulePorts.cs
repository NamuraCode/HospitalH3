using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.ports
{
    internal interface AppointmentSchedulePorts
    {
        public void ScheduleAppointment();
        public void CancelAppointment();
        public void UpdateAppointment();
    }
}
