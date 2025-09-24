using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.domain.ports;
using Hospital.domain.model;

namespace Hospital.domain.services
{
    internal class AppointmentServices
    {
        private AppointmentSchedulePorts appointmentSchedulePorts;

        public void ScheduleAppointment(Appointment appointmentCreated)
        {
            bool existAppointment = appointmentSchedulePorts.FindAppointmentByDoctorAndTime(doctorId: appointmentCreated.Doctor.Id, dateAppointment: appointmentCreated.DateAdmission);
            if (existAppointment)
            {
                throw new Exception("El doctor ya tiene una cita agendada en ese horario.");
            }
            appointmentSchedulePorts.ScheduleAppointment(appointment: appointmentCreated);
        }

        public void CancelAppointment(Appointment appointment)
        {
            List<Appointment> existAppointment = appointmentSchedulePorts.GetAppointmentsByPatient(patientId: appointment.Patient.Id);
            if (existAppointment.Count == 0)
            {
                throw new Exception("El paciente no tiene citas agendadas.");
            }
            appointmentSchedulePorts.CancelAppointment(patientId: appointment.Patient.Id, doctorId: appointment.Doctor.Id);
        }
    }
}
