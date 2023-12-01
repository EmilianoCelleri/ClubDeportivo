namespace ClubDeportivo
{
    partial class frmComprobantePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprobantePago));
            pnlTitulo = new Panel();
            lblClub = new Label();
            lblTitulo = new Label();
            pnlDatosClub = new Panel();
            pnlDatosSocio = new Panel();
            lblFormaPago = new Label();
            lblGracias = new Label();
            lblVencimiento = new Label();
            lblFecha = new Label();
            lblSocio = new Label();
            btnImprimir = new Button();
            pnlTitulo.SuspendLayout();
            pnlDatosClub.SuspendLayout();
            pnlDatosSocio.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.Controls.Add(lblClub);
            pnlTitulo.Location = new Point(28, 18);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(748, 52);
            pnlTitulo.TabIndex = 0;
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblClub.Location = new Point(18, 10);
            lblClub.Name = "lblClub";
            lblClub.Size = new Size(176, 32);
            lblClub.TabIndex = 0;
            lblClub.Text = "Club Deportivo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(174, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(398, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Comprobante de pago de cuota";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDatosClub
            // 
            pnlDatosClub.Controls.Add(lblTitulo);
            pnlDatosClub.Location = new Point(28, 76);
            pnlDatosClub.Name = "pnlDatosClub";
            pnlDatosClub.Size = new Size(748, 89);
            pnlDatosClub.TabIndex = 1;
            // 
            // pnlDatosSocio
            // 
            pnlDatosSocio.Controls.Add(lblFormaPago);
            pnlDatosSocio.Controls.Add(lblGracias);
            pnlDatosSocio.Controls.Add(lblVencimiento);
            pnlDatosSocio.Controls.Add(lblFecha);
            pnlDatosSocio.Controls.Add(lblSocio);
            pnlDatosSocio.Location = new Point(27, 175);
            pnlDatosSocio.Name = "pnlDatosSocio";
            pnlDatosSocio.Size = new Size(751, 192);
            pnlDatosSocio.TabIndex = 2;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFormaPago.Location = new Point(24, 143);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(122, 21);
            lblFormaPago.TabIndex = 4;
            lblFormaPago.Text = "Forma de pago: ";
            // 
            // lblGracias
            // 
            lblGracias.AutoSize = true;
            lblGracias.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGracias.Location = new Point(658, 154);
            lblGracias.Name = "lblGracias";
            lblGracias.Size = new Size(65, 20);
            lblGracias.TabIndex = 3;
            lblGracias.Text = "¡Gracias!";
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVencimiento.Location = new Point(23, 102);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(103, 21);
            lblVencimiento.TabIndex = 2;
            lblVencimiento.Text = "Vencimiento: ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(23, 59);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 21);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha: ";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSocio.Location = new Point(24, 18);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(55, 21);
            lblSocio.TabIndex = 0;
            lblSocio.Text = "Socio: ";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(639, 377);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(138, 42);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmComprobantePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 425);
            Controls.Add(btnImprimir);
            Controls.Add(pnlDatosSocio);
            Controls.Add(pnlDatosClub);
            Controls.Add(pnlTitulo);
            Name = "frmComprobantePago";
            Text = "Comprobante de Pago";
            Load += frmComprobantePago_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlDatosClub.ResumeLayout(false);
            pnlDatosClub.PerformLayout();
            pnlDatosSocio.ResumeLayout(false);
            pnlDatosSocio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlDatosClub;
        private Panel pnlDatosSocio;
        private Button btnImprimir;
        private Label lblTitulo;
        private Label lblVencimiento;
        private Label lblFecha;
        private Label lblSocio;
        private Label lblClub;
        private Label lblGracias;
        private Label lblFormaPago;
    }
}