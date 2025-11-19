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

        public CreateUser createUser { get; private set; }

        public HumanResourcesUseCase humanResourcesUseCase{ get; private set; }

        public UserInputs UserInput { get; private set; }

        public UserBuilder UserBuilder { get; private set; }    

        public Config()
        {
            try
            {
                //puertos de la base de datos usuarios
                UserPorts = new MySqlUserPort();

                //servicios de la aplicacion usuarios
                createUser = new CreateUser(UserPorts);

                //casos de uso
                humanResourcesUseCase = new HumanResourcesUseCase(new CreateUser(UserPorts));

                UserBuilder = new UserBuilder();

                UserInput = new UserInputs(UserBuilder, humanResourcesUseCase);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al inicializar la aplicación: {ex.Message}", "Error",
                   System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw; 
            }


        }
    }
}
