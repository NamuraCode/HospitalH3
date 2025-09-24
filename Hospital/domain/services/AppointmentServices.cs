using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.domain.ports;

namespace Hospital.domain.services
{
    internal class AppointmentServices
    {
        private AppointmentSchedulePorts appointmentSchedulePorts;

        public void ScheduleAppointment()
        {
            appointmentSchedulePorts.ScheduleAppointment();
        }

        public void CancelAppointment()
        {

        }
        public void UpdateAppointment()
        {

        }


    }
}
