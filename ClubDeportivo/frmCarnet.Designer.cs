namespace ClubDeportivo
{
    partial class frmCarnet
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            btnImprimir = new Button();
            lblFecha = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(262, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(93, 30);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(262, 106);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(92, 30);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.Location = new Point(262, 159);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(50, 30);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(470, 278);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(114, 41);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.Location = new Point(262, 203);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(68, 30);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFecha);
            Controls.Add(btnImprimir);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmCarnet";
            Text = "frmCarnet";
            Load += frmCarnet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Button btnImprimir;
        private Label lblFecha;
    }
}