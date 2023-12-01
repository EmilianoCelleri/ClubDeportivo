namespace ClubDeportivo
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnSalir = new Button();
            lblIngreso = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(330, 186);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(104, 40);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(277, 72);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre de usuario";
            txtUsuario.Size = new Size(206, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(277, 125);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Contraseña";
            txtPass.Size = new Size(206, 23);
            txtPass.TabIndex = 2;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 241);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(81, 33);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.BackColor = SystemColors.Control;
            lblIngreso.Location = new Point(277, 29);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(101, 15);
            lblIngreso.TabIndex = 4;
            lblIngreso.Text = "Ingreso al sistema";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(551, 286);
            Controls.Add(lblIngreso);
            Controls.Add(btnSalir);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Name = "Login";
            Text = "Ingreso al sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnSalir;
        private Label lblIngreso;
    }
}