namespace ClubDeportivo
{
    partial class frmMostrarDeudores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarDeudores));
            dtgvDeudores = new DataGridView();
            btnVolver = new Button();
            nro_socio = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Vencimiento_Cuota = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvDeudores).BeginInit();
            SuspendLayout();
            // 
            // dtgvDeudores
            // 
            dtgvDeudores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDeudores.Columns.AddRange(new DataGridViewColumn[] { nro_socio, Nombre, Apellido, Vencimiento_Cuota });
            dtgvDeudores.Location = new Point(143, 64);
            dtgvDeudores.Name = "dtgvDeudores";
            dtgvDeudores.RowTemplate.Height = 25;
            dtgvDeudores.Size = new Size(595, 360);
            dtgvDeudores.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(32, 368);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(105, 53);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver al menu principal";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // nro_socio
            // 
            nro_socio.HeaderText = "Numero de socio";
            nro_socio.Name = "nro_socio";
            nro_socio.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Vencimiento_Cuota
            // 
            Vencimiento_Cuota.HeaderText = "Vencio el dia";
            Vencimiento_Cuota.Name = "Vencimiento_Cuota";
            Vencimiento_Cuota.Width = 200;
            // 
            // frmMostrarDeudores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(dtgvDeudores);
            Name = "frmMostrarDeudores";
            Text = "Deudores";
            Load += frmMostrarDeudores_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDeudores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvDeudores;
        private Button btnVolver;
        private DataGridViewTextBoxColumn nro_socio;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Vencimiento_Cuota;
    }
}