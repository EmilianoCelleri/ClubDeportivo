namespace ClubDeportivo
{
    partial class frmEntregarCarnet
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
            lblDniSocio = new Label();
            txtDniSocio = new TextBox();
            btnEmitirCarnet = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblDniSocio
            // 
            lblDniSocio.AutoSize = true;
            lblDniSocio.Location = new Point(276, 61);
            lblDniSocio.Name = "lblDniSocio";
            lblDniSocio.Size = new Size(129, 15);
            lblDniSocio.TabIndex = 0;
            lblDniSocio.Text = "Ingrese el Dni del Socio";
            // 
            // txtDniSocio
            // 
            txtDniSocio.Location = new Point(275, 98);
            txtDniSocio.Name = "txtDniSocio";
            txtDniSocio.PlaceholderText = "DNI";
            txtDniSocio.Size = new Size(159, 23);
            txtDniSocio.TabIndex = 1;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.Location = new Point(275, 141);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(161, 38);
            btnEmitirCarnet.TabIndex = 2;
            btnEmitirCarnet.Text = "Emitir Carnet";
            btnEmitirCarnet.UseVisualStyleBackColor = true;
            btnEmitirCarnet.Click += btnEmitirCarnet_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(25, 380);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(96, 46);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver al menu principal";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmEntregarCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnEmitirCarnet);
            Controls.Add(txtDniSocio);
            Controls.Add(lblDniSocio);
            Name = "frmEntregarCarnet";
            Text = "Entrega de Carnet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDniSocio;
        private TextBox txtDniSocio;
        private Button btnEmitirCarnet;
        private Button btnVolver;
    }
}