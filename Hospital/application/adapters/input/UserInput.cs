using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.application.adapters.input.builders;
using Hospital.application.usecases;
using Hospital.domain.model;

namespace Hospital.application.adapters.input
{
    internal class UserInput
    {
        private UserBuilder userBuilder { get; set; } 
        private AdminUseCase adminUseCase { get; set; }
        public UserInput(UserBuilder userBuilder, AdminUseCase adminUseCase)
        {
            this.userBuilder = userBuilder;
            this.adminUseCase = adminUseCase;
        }
        public void CreateUser(
            string role,
            string nameUser,
            string password,
            string name,
            string id,
            string document,
            string email,
            string phone,
            string age,
            string direction,
            string contactName,
            string contactRelation,
            string contactPhone,
            string contactEmail
        )
        {
            User user = userBuilder.create(
                role,
                nameUser,
                password,
                name,
                id,
                document,
                email,
                phone,
                age,
                direction,
                contactName,
                contactRelation,
                contactPhone,
                contactEmail
            );
            adminUseCase.CreateUserAdmin(user);
        }
    }
}
