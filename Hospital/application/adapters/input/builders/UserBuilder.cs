using Hospital.application.adapters.input.validators;
using Hospital.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.application.adapters.input.builders
{
    public class UserBuilder
    {
        private PersonValidator personValidator;
        private UserValidator userValidator;

        public UserBuilder()
        {
            personValidator = new PersonValidator();
            userValidator = new UserValidator();
        }

        internal PersonValidator PersonValidator { get => personValidator; set => personValidator = value; }
        internal UserValidator UserValidator { get => userValidator; set => userValidator = value; }

        public User create(
            string role,
            string nameUser,
            string password,
            string name, 
            //string id, 
            string document,
            string email, 
            string phone, 
            string age, 
            string direction
            )
        {
            User user = new User { 
                Role = UserValidator.ValidateRole(role),
                NameUser = UserValidator.ValidateUserName(nameUser),
                Password = UserValidator.ValidatePassword(password),
                Name = PersonValidator.ValidateName(name),
                Id = PersonValidator.ValidateId(document),
                Email = PersonValidator.ValidateEmail(email),
                Phone = personValidator.PhoneNumberValidator(phone),
                Document = PersonValidator.ValidateId(document),
                DateBirth = PersonValidator.ValidateAge(age),
                Direction = PersonValidator.ValidationDirection(direction)
            };
            return user;
        }
    }
}
