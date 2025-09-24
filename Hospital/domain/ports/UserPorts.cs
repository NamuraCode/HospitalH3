using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.domain.model;

namespace Hospital.domain.ports
{
    internal interface UserPorts
    {
        public bool FindUserById(int userId)
        {
            // guardar el usuario base de datos
            Console.WriteLine($"Usuario {userId} no existe.");
            return false;
        }
        public void SaveUser(User user)
        {
            // guardar el usuario base de datos
            Console.WriteLine($"Usuario {user.NameUser} guardado exitosamente.");
        }

        public void DeleteUser(int userId)
        {
            // eliminar el usuario de la base de datos
            Console.WriteLine($"Usuario con ID {userId} eliminado exitosamente.");
        }

        public void UpdateUser(User user)
        {
            // actualizar el usuario en la base de datos
            Console.WriteLine($"Usuario {user.NameUser} actualizado exitosamente.");
        }
    }
}
