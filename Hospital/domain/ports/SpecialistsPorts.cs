using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.domain.model;

namespace Hospital.domain.ports
{
    internal interface SpecialistsPorts
    {
        public List<User> Specialists() { 
            List<User> specialists = new List<User>
            {
                new User
                {
                    Name = "Dr. Juan Perez",
                    Id = 1001,
                    Email = "",
                    Phone = 1234567890,
                    DateBirth = new DateTime(1980, 5, 15),
                    Direction = "Calle 123 #23-12b",
                    Role = "Cardiologo",
                    NameUser = "DrJuanPerez",
                    Password = "password123",
                },
            };

            return specialists;
        }
        public void ScheduleAppointment()
        {
            // agendar una cita
        }
        public void CancelAppointment()
        {
            // cancelar una cita
        }
        public void UpdateAppointment()
        {
            // actualizar una cita
        }
    }
}
