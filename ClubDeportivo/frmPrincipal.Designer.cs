namespace ClubDeportivo
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            btnRegistrarSocio = new Button();
            btnDeudores = new Button();
            btnEntregaCarnet = new Button();
            btnCobroCuota = new Button();
            lblIngreso = new Label();
            btnSalir = new Button();
            btnRegistrarNo_Socio = new Button();
            SuspendLayout();
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.Location = new Point(251, 85);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(136, 45);
            btnRegistrarSocio.TabIndex = 0;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnDeudores
            // 
            btnDeudores.Location = new Point(251, 151);
            btnDeudores.Name = "btnDeudores";
            btnDeudores.Size = new Size(136, 45);
            btnDeudores.TabIndex = 1;
            btnDeudores.Text = "Ver socios deudores";
            btnDeudores.UseVisualStyleBackColor = true;
            btnDeudores.Click += btnDeudores_Click;
            // 
            // btnEntregaCarnet
            // 
            btnEntregaCarnet.Location = new Point(424, 85);
            btnEntregaCarnet.Name = "btnEntregaCarnet";
            btnEntregaCarnet.Size = new Size(136, 45);
            btnEntregaCarnet.TabIndex = 2;
            btnEntregaCarnet.Text = "Entrega de carnet";
            btnEntregaCarnet.UseVisualStyleBackColor = true;
            btnEntregaCarnet.Click += btnEntregaCarnet_Click;
            // 
            // btnCobroCuota
            // 
            btnCobroCuota.Location = new Point(424, 151);
            btnCobroCuota.Name = "btnCobroCuota";
            btnCobroCuota.Size = new Size(136, 45);
            btnCobroCuota.TabIndex = 3;
            btnCobroCuota.Text = "Cobro cuota";
            btnCobroCuota.UseVisualStyleBackColor = true;
            btnCobroCuota.Click += btnCobroCuota_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(17, 12);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(0, 15);
            lblIngreso.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 349);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(81, 33);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrarNo_Socio
            // 
            btnRegistrarNo_Socio.Location = new Point(337, 216);
            btnRegistrarNo_Socio.Name = "btnRegistrarNo_Socio";
            btnRegistrarNo_Socio.Size = new Size(136, 45);
            btnRegistrarNo_Socio.TabIndex = 6;
            btnRegistrarNo_Socio.Text = "Registrar No Socio";
            btnRegistrarNo_Socio.UseVisualStyleBackColor = true;
            btnRegistrarNo_Socio.Click += btnRegistrarNo_Socio_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(746, 394);
            Controls.Add(btnRegistrarNo_Socio);
            Controls.Add(btnSalir);
            Controls.Add(lblIngreso);
            Controls.Add(btnCobroCuota);
            Controls.Add(btnEntregaCarnet);
            Controls.Add(btnDeudores);
            Controls.Add(btnRegistrarSocio);
            Name = "frmPrincipal";
            Text = "Club Deportivo";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarSocio;
        private Button btnDeudores;
        private Button btnEntregaCarnet;
        private Button btnCobroCuota;
        private Label lblIngreso;
        private Button btnSalir;
        private Button btnRegistrarNo_Socio;
    }
}