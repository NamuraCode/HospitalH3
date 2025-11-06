using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.domain.services;
using Hospital.domain.model;

namespace Hospital.application.usecases
{
    internal class AdminUseCase
    {
        private UserServices userServices{get; set; }   
        public AdminUseCase(UserServices userServices)
        {
            this.userServices = userServices;
        }

        public void CreateUserAdmin(User user) {
            userServices.CreateUser(user);
        }
    }
}
