using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Hospital.application.adapters.input.validators
{
    internal class SimpleValidator
    {
        public string StringNotNullOrEmpty(string value, string fieldname)
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"El campo {fieldname} no puede ser nulo o vacio");
            }

            return value;
        }

        public int IntNotNullOrEmpty(string value, string fieldname)
        {
            StringNotNullOrEmpty(value, fieldname);
            if(!int.TryParse(value, out int result))
            {
                throw new ArgumentException($"El campo {fieldname} debe ser un numero entero valido");
            }

            return result;
        }

        public ulong ULongNotNullOrEmpty(string value, string fieldname)
        {
            StringNotNullOrEmpty(value, fieldname);
            if(!ulong.TryParse(value, out ulong result))
            {
                throw new ArgumentException($"El campo {fieldname} debe ser un numero entero positivo valido");
            }

            return result;
        }

        public long LongNotNullOrEmpty(string value, string fieldname)
        {
            StringNotNullOrEmpty(value, fieldname);
            if(!long.TryParse(value, out long result))
            {
                throw new ArgumentException($"El campo {fieldname} debe ser un numero entero valido");
            }

            return result;
        }

        public string ValidatePassWord(string password, string fieldname)
        {
            StringNotNullOrEmpty(password, fieldname);
            if(password.Length < 8)
            {
                throw new ArgumentException($"El campo {fieldname} debe tener al menos 8 caracteres");
            }

            if(!password.Any(char.IsUpper))
            {
                throw new ArgumentException($"El campo {fieldname} debe tener al menos una letra mayuscula");
            }

            if(!password.Any(char.IsLower))
            {
                throw new ArgumentException($"El campo {fieldname} debe tener al menos una letra minuscula");
            }

            if(!password.Any(char.IsDigit))
            {
                throw new ArgumentException($"El campo {fieldname} debe tener al menos un numero");
            }

            if (!Regex.IsMatch(password, @"[^\p{L}\p{N}]"))
            {
                throw new ArgumentException($"El campo {fieldname} debe contener al menos un carácter especial");
            }

            return password;
        }
    }
}
