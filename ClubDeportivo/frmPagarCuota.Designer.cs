namespace ClubDeportivo
{
    partial class frmPagarCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagarCuota));
            lblNroSocio = new Label();
            txtNroSocio = new TextBox();
            groupBox1 = new GroupBox();
            optTarjeta = new RadioButton();
            optEfectivo = new RadioButton();
            btnPagar = new Button();
            btnVolver = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNroSocio
            // 
            lblNroSocio.AutoSize = true;
            lblNroSocio.Location = new Point(247, 102);
            lblNroSocio.Name = "lblNroSocio";
            lblNroSocio.Size = new Size(128, 15);
            lblNroSocio.TabIndex = 0;
            lblNroSocio.Text = "Ingrese el Nro de Socio";
            // 
            // txtNroSocio
            // 
            txtNroSocio.Location = new Point(248, 141);
            txtNroSocio.Name = "txtNroSocio";
            txtNroSocio.PlaceholderText = "Nro de socio";
            txtNroSocio.Size = new Size(134, 23);
            txtNroSocio.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optTarjeta);
            groupBox1.Controls.Add(optEfectivo);
            groupBox1.Location = new Point(465, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(109, 115);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medio de Pago";
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(18, 76);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(59, 19);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(18, 40);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(67, 19);
            optEfectivo.TabIndex = 0;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(247, 183);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(135, 34);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(23, 379);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(117, 50);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver al menu principal";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmPagarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnPagar);
            Controls.Add(groupBox1);
            Controls.Add(txtNroSocio);
            Controls.Add(lblNroSocio);
            Name = "frmPagarCuota";
            Text = "Pagar Cuota de Socio";
            Load += frmPagarCuota_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNroSocio;
        private TextBox txtNroSocio;
        private GroupBox groupBox1;
        private RadioButton optTarjeta;
        private RadioButton optEfectivo;
        private Button btnPagar;
        private Button btnVolver;
    }
}