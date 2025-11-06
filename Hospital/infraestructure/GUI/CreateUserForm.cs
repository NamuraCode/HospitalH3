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
        public CreateUserForm()
        {
        }

        public CreateUserForm(AdminUseCase adminUseCase)
        {
            this.adminUseCase = adminUseCase ?? throw new ArgumentNullException(nameof(AdminUseCase));
            InitializeComponent();
        }

    }
}
