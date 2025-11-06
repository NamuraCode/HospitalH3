using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.application.adapters.input.validators
{
    internal class UserValidator:SimpleValidator
    {
        public string ValidateRole(string role)
        {
            return StringNotNullOrEmpty(role, "Rol");
        }
        public string ValidateUserName(string username)
        {
            return StringNotNullOrEmpty(username, "Nombre de Usuario");
        }
        public string ValidatePassword(string password)
        {
            return ValidatePassWord(password, "Contraseña");
        }
    }
}
