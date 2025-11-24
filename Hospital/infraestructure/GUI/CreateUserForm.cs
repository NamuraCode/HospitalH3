using System;
using System.Windows.Forms;
using Hospital.application.adapters.input; 

namespace Hospital.infraestructure.GUI
{
    public partial class CreateUserForm : Form
    {
        private readonly UserInputs userInputs;

  
        public CreateUserForm(UserInputs userInputs)
        {
            this.userInputs = userInputs ?? throw new ArgumentNullException(nameof(userInputs));
            InitializeComponent();
        }
        private void btnCreate_Click(object? sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
            {
                return;
            }

            try
            {
                if (!long.TryParse(txtPhone.Text.Trim(), out var phoneValue) || phoneValue <= 0)
                {
                    MessageBox.Show("El campo Teléfono debe ser un número entero válido y mayor que cero.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return;
                }

                txtPhone.Text = phoneValue.ToString();

                userInputs.CreateUser(
                    role: txtRole.Text.Trim(),
                    nameUser: txtUserName.Text.Trim(),
                    password: txtPassword.Text, 
                    name: txtName.Text.Trim(),
                    document: txtDocument.Text.Trim(),
                    email: txtEmail.Text.Trim(),
                    phone: txtPhone.Text,
                    age: txtAge.Text.Trim(),
                    direction: txtDirection.Text.Trim()
                );

                MessageBox.Show("Usuario creado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al crear el usuario:\n{ex.Message}",
                                "Error de Creación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateRequiredFields()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("El campo Usuario es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("El campo Contraseña es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            return true;
        }
    }
}