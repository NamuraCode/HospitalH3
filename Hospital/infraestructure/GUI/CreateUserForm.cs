using Hospital.application.adapters.input;
using Hospital.application.usecases;
using Hospital.infraestructure.config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.infraestructure.GUI
{
    public partial class CreateUserForm : Form
    {
        private readonly UserInputs userInputs;
        public CreateUserForm(UserInputs userInputs)
        {
            this.userInputs = userInputs;
            InitializeComponent();
        }
    }
}
