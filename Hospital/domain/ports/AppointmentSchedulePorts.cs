using Hospital.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.ports
{
    internal interface AppointmentSchedulePorts
    {
        public bool FindAppointmentByDoctorAndTime(ulong doctorId, DateTime dateAppointment);
        public List<Appointment> GetAppointmentsByPatient(ulong patientId);
        public void ScheduleAppointment(Appointment appointment);
        public void CancelAppointment(ulong patientId, ulong doctorId);
        public void UpdateAppointment();
    }
}
