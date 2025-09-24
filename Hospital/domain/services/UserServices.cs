using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Hospital.domain.model;
using Hospital.domain.ports;

namespace Hospital.domain.services
{
    internal class UserServices
    {
        private UserPorts userPorts;
        public void CreateUser(User user)
        {
            if(user != null)
            {
                bool isValid = !string.IsNullOrEmpty(user.NameUser) && !string.IsNullOrEmpty(user.Password) && !string.IsNullOrEmpty(user.Role);
                if (!isValid)
                {
                    throw new ArgumentException("El usuario debe tener un nombre de usuario, una contraseña y un rol válidos.");
                }
                else
                {
                    bool userExist = userPorts.FindUserById(userId: user.Id);
                    if (userExist)
                    {
                        throw new InvalidOperationException($"El usuario con ID {user.Id} ya existe.");
                    }
                    else
                    {
                        userPorts.SaveUser(user);
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(user), "El usuario no puede ser nulo.");
            }
        }

        public void UpdateUser()
        {
            // Lógica para actualizar un usuario
        }

        public void DeleteUser()
        {
            // Lógica para eliminar un usuario
        }
    }
}
