using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.domain.services;
using Hospital.domain.model;

namespace Hospital.application.usecases
{
    public class HumanResourcesUseCase
    {   
        private CreateUser createUser { get; set; }

        public HumanResourcesUseCase(CreateUser createUser)
        {
            this.createUser = createUser;
        }

        public void CreateUser(User user) {
            createUser.Create(user);
        }
    }
}
