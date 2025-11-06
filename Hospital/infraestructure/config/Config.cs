using Hospital.application.adapters.input;
using Hospital.application.adapters.input.builders;
using Hospital.application.usecases;
using Hospital.domain.ports;
using Hospital.domain.services;
using Hospital.infraestructure.adapters.output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.infraestructure.config
{

    internal class Config
    {
        public UserPorts UserPorts { get; private set; }

        public UserServices UserServices { get; private set; }

        public AdminUseCase AdminUseCase { get; private set; }

        public UserInput UserInput { get; private set; }

        public UserBuilder UserBuilder { get; private set; }    

        public Config()
        {
            try
            {
                //puertos de la base de datos usuarios
                UserPorts = new MySqlUserPort();

                //servicios de la aplicacion usuarios
                UserServices = new UserServices(UserPorts);

                //casos de uso
                AdminUseCase = new AdminUseCase(UserServices);

                UserBuilder = new UserBuilder();

                UserInput = new UserInput(UserBuilder, AdminUseCase);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Error al inicializar los puertos de la base de datos: " + ex.Message);
            }


        }
    }
}
