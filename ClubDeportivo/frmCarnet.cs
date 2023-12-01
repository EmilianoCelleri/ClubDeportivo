using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace ClubDeportivo
{
    public partial class frmCarnet : Form
    {
        public frmCarnet()
        {
            InitializeComponent();
        }

        public string? nombre;
        public string? apellido;
        public int dni;
        public DateTime fecha;


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm);
            pd.Print();

            btnImprimir.Visible = true;

            MessageBox.Show("Carnet generado correctamente, se redirige al menu principal", "Entrega de carnet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrincipal principal = new frmPrincipal();
            this.Close();
            principal.Show();
        }

        private void ImprimirForm(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(0, 0);
            e.Graphics.DrawImage(img, p);
        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre: " + nombre;
            lblApellido.Text = "Apellido: " + apellido;
            lblDni.Text = "DNI: " + Convert.ToString(dni);
            lblFecha.Text = "Fecha de hoy: " + DateTime.UtcNow.ToShortDateString();

        }
    }
}
