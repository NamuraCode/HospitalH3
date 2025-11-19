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
    public class UserInputs
    {
        private readonly UserBuilder userBuilder;
        private readonly HumanResourcesUseCase humanResourcesUseCase;

        public UserInputs(UserBuilder userBuilder, HumanResourcesUseCase humanResourcesUseCase)
        {
            this.userBuilder = userBuilder;
            this.humanResourcesUseCase = humanResourcesUseCase;
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
            humanResourcesUseCase.CreateUser(user);
        }
    }
}
