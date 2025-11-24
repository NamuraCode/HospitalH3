namespace Hospital.infraestructure.GUI
{
    partial class CreateUserForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controles de Usuario Principal (ajustados para reflejar solo lo necesario)
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TextBox txtDirection;

        // Botones
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // Inicialización de Controles
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDocument = new System.Windows.Forms.Label();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Variables de Posicionamiento
            int xLabel = 12;
            int xInput = 120;
            int wInput = 200;
            int y = 15;
            int step = 30;
            int wLabel = 100;

            // --- Controles de Usuario ---

            // Role
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(xLabel, y);
            this.lblRole.Size = new System.Drawing.Size(wLabel, 20);
            this.lblRole.Text = "Rol:";
            this.txtRole.Location = new System.Drawing.Point(xInput, y - 3);
            this.txtRole.Size = new System.Drawing.Size(wInput, 23);
            this.txtRole.Name = "txtRole";

            y += step;
            // Username
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(xLabel, y);
            this.lblUserName.Size = new System.Drawing.Size(wLabel, 20);
            this.lblUserName.Text = "Usuario:";
            this.txtUserName.Location = new System.Drawing.Point(xInput, y - 3);
            this.txtUserName.Size = new System.Drawing.Size(wInput, 23);
            this.txtUserName.Name = "txtUserName";

            y += step;
            // Password
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(xLabel, y);
            this.lblPassword.Size = new System.Drawing.Size(wLabel, 20);
            this.lblPassword.Text = "Contraseña:";
            this.txtPassword.Location = new System.Drawing.Point(xInput, y - 3);
            this.txtPassword.Size = new System.Drawing.Size(wInput, 23);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;

            y += step;
            // Name
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(xLabel, y);
            this.lblName.Size = new System.Drawing.Size(wLabel, 20);
            this.lblName.Text = "Nombre:";
            this.txtName.Location = new System.Drawing.Point(xInput, y - 3);
            this.txtName.Size = new System.Drawing.Size(wInput, 23);
            this.txtName.Name = "txtName";

            y += step;
            // Document
            this.lblDocument.AutoSize = true;
            this.lblDocument.Location = new System.Drawing.Point(xLabel, y);
            this.lblDocument.Size = new System.Drawing.Size(wLabel, 20);
            this.lblDocument.Text = "Documento:";
            this.txtDocument.Location = new System.Drawing.Point(xInput, y - 3);
            this.txtDocument.Size = new System.Drawing.Size(wInput, 23);
            this.txtDocument.Name = "txtDocument";

            y += step;
            // Email
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(xLabel, y);
            this.lblEmail.Size = new System.Drawing.Size(wLabel, 20);
            this.lblEmail.Text = "Email:";
            this.txtEmail.Location = new System.Drawing.Point(xInput, y - 3);
            this.txtEmail.Size = new System.Drawing.Size(wInput, 23);
            this.txtEmail.Name = "txtEmail";

            y += step;
            // Phone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(xLabel, y);
            this.lblPhone.Size = new System.Drawing.Size(wLabel, 20);
            this.lblPhone.Text = "Teléfono:";
            this.txtPhone.Location = new System.Drawing.Point(xInput, y - 3);
            this.txtPhone.Size = new System.Drawing.Size(wInput, 23);
            this.txtPhone.Name = "txtPhone";

            y += step;
            // Age
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(xLabel, y);
            this.lblAge.Size = new System.Drawing.Size(wLabel, 20);
            this.lblAge.Text = "Edad / Fecha:";
            this.txtAge.Location = new System.Drawing.Point(xInput, y - 3);
            this.txtAge.Size = new System.Drawing.Size(wInput, 23);
            this.txtAge.Name = "txtAge";

            y += step;
            // Direction
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(xLabel, y);
            this.lblDirection.Size = new System.Drawing.Size(wLabel, 20);
            this.lblDirection.Text = "Dirección:";
            this.txtDirection.Location = new System.Drawing.Point(xInput, y - 3);
            this.txtDirection.Size = new System.Drawing.Size(wInput, 45); // Altura aumentada para dirección
            this.txtDirection.Multiline = true;
            this.txtDirection.Name = "txtDirection";

            y += 60; // Ajuste por la altura del TextBox de Dirección

            // --- Botones ---

            this.btnCreate.Text = "Crear";
            this.btnCreate.Location = new System.Drawing.Point(xInput, y);
            this.btnCreate.Size = new System.Drawing.Size(100, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new System.Drawing.Point(xInput + 110, y);
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // --- Configuración Final del Formulario ---

            this.ClientSize = new System.Drawing.Size(350, y + 40); // Tamaño del formulario ajustado
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.txtDirection);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);

            this.Name = "CreateUserForm";
            this.Text = "Crear Usuario";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}