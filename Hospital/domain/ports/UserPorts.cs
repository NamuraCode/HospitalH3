using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.domain.model;

namespace Hospital.domain.ports
{
    public interface UserPorts
    {
        public bool FindUserById(ulong userId);
        public void SaveUser(User user);
        public void DeleteUser(ulong userId);
        public void UpdateUser(User user);
    }
}
