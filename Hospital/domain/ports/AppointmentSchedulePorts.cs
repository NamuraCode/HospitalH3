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
        public bool FindAppointmentByDoctorAndTime(int doctorId, DateTime dateAppointment);
        public List<Appointment> GetAppointmentsByPatient(int patientId);
        public void ScheduleAppointment(Appointment appointment);
        public void CancelAppointment(int patientId, int doctorId);
        public void UpdateAppointment();
    }
}
