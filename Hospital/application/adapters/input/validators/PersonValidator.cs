using Hospital.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital.application.adapters.input.validators
{
    internal class PersonValidator: SimpleValidator
    {
        public string ValidateName(string name)
        {
            return StringNotNullOrEmpty(name, "Nombre");
        }
        public ulong ValidateId(string id)
        {
            return ULongNotNullOrEmpty(id, "Identificacion");
        }
        public string ValidateEmail(string email)
        {
            return StringNotNullOrEmpty(email, "Correo Electronico");
        }
        public int ValidatePhone(string phone)
        {
            return IntNotNullOrEmpty(phone, "Telefono");
        }
        public DateTime ValidateAge(string age)
        {
            string date = StringNotNullOrEmpty(age, "Edad");
            if(!DateTime.TryParse(date, out DateTime dateValue))
            {
                throw new ArgumentException("La edad debe ser una fecha valida");
            }
            return dateValue;

        }
        public string ValidationDirection(string direction)
        {
            return StringNotNullOrEmpty(direction, "Direccion");
        }
    }
}
