namespace ClubDeportivo
{
    partial class frmInscribirNoSocio
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
            btnRegistrar = new Button();
            txtDni = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblDni = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblInscribir = new Label();
            btnLimpiar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(383, 314);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(116, 43);
            btnRegistrar.TabIndex = 28;
            btnRegistrar.Text = "Registrar No Socio";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(308, 263);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Numero de DNI";
            txtDni.Size = new Size(287, 23);
            txtDni.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(308, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email@email.com";
            txtEmail.Size = new Size(287, 23);
            txtEmail.TabIndex = 26;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(308, 194);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(287, 23);
            txtTelefono.TabIndex = 25;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(308, 162);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(287, 23);
            txtDireccion.TabIndex = 24;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(308, 130);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(287, 23);
            txtApellido.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(308, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(287, 23);
            txtNombre.TabIndex = 22;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(241, 263);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 21;
            lblDni.Text = "DNI";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(241, 231);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(241, 197);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 19;
            lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(241, 166);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 18;
            lblDireccion.Text = "Direccion";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(241, 133);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 17;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(241, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 16;
            lblNombre.Text = "Nombre";
            // 
            // lblInscribir
            // 
            lblInscribir.AutoSize = true;
            lblInscribir.Location = new Point(256, 43);
            lblInscribir.Name = "lblInscribir";
            lblInscribir.Size = new Size(138, 15);
            lblInscribir.TabIndex = 15;
            lblInscribir.Text = "Inscribir Nuevo No Socio";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(668, 390);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 43);
            btnLimpiar.TabIndex = 29;
            btnLimpiar.Text = "Limpiar Formulario";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(21, 389);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 43);
            btnVolver.TabIndex = 30;
            btnVolver.Text = "Volver a la pantalla principal";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmInscribirNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
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
            Name = "frmInscribirNoSocio";
            Text = "Inscribir No Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private TextBox txtDni;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblDni;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblInscribir;
        private Button btnLimpiar;
        private Button btnVolver;
    }
}