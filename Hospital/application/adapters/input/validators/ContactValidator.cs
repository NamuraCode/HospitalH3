using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hospital.application.adapters.input.validators
{
    internal class ContactValidator: SimpleValidator
    {
        public string RelationValidator(string relation)
        {
            string relationValidated = StringNotNullOrEmpty(relation, "Relacion");
            if (relationValidated.Length < 2 || relationValidated.Length > 50)
            {
                throw new ArgumentException("La relación debe tener entre 2 y 50 caracteres.");
            }
            return relation;
        }

        public string NameValidator(string name)
        {
            string nameValidated = StringNotNullOrEmpty(name, "Nombre");
            if (nameValidated.Length < 2 || nameValidated.Length > 100)
            {
                throw new ArgumentException("El nombre debe tener entre 2 y 100 caracteres.");
            }
            return name;
        }

        public string PhoneNumberValidator(string phoneNumber)
        {
            string phoneNumberValidated = StringNotNullOrEmpty(phoneNumber, "Número de Teléfono");
            if (!Regex.IsMatch(phoneNumberValidated, @"^\+?[1-9]\d{1,14}$"))
            {
                throw new ArgumentException("El número de teléfono no es válido.");
            }
            return phoneNumber;
        }

        public string EmailValidator(string email)
        {
            string emailValidated = StringNotNullOrEmpty(email, "Correo Electrónico");
            if (!Regex.IsMatch(emailValidated, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("El correo electrónico no es válido.");
            }
            return email;
        }
    }
}
