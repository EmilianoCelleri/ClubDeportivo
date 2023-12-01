namespace ClubDeportivo
{
    partial class frmInscribirSocio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscribirSocio));
            lblInscribir = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblDni = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDni = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblInscribir
            // 
            lblInscribir.AutoSize = true;
            lblInscribir.Location = new Point(250, 42);
            lblInscribir.Name = "lblInscribir";
            lblInscribir.Size = new Size(119, 15);
            lblInscribir.TabIndex = 0;
            lblInscribir.Text = "Inscribir Nuevo Socio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(235, 99);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(235, 132);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(235, 165);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(235, 196);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(235, 230);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(235, 262);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(302, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(287, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(302, 129);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(287, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(302, 161);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(287, 23);
            txtDireccion.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(302, 193);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(287, 23);
            txtTelefono.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(302, 230);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email@email.com";
            txtEmail.Size = new Size(287, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(302, 262);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Numero de DNI";
            txtDni.Size = new Size(287, 23);
            txtDni.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(377, 313);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(116, 43);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar Socio";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(656, 384);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 43);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar Formulario";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(29, 384);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 43);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver a la pantalla principal";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmInscribirSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtDni);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDni);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblInscribir);
            Name = "frmInscribirSocio";
            Text = "Inscribir Nuevo Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInscribir;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblDni;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDni;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
    }
}