using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmComprobantePago : Form
    {
        public frmComprobantePago()
        {
            InitializeComponent();
        }

        public string? nro_socio;
        public DateTime fecha;
        public DateTime vencimiento;
        public string? forma_pago;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm);
            pd.Print();

            btnImprimir.Visible = true;

            MessageBox.Show("Comprobante generado correctamente", "Pago de cuota", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmComprobantePago_Load(object sender, EventArgs e)
        {
            lblSocio.Text = "Socio: " + nro_socio;
            lblFecha.Text = "Fecha de pago: " + DateTime.UtcNow.ToShortDateString();
            lblVencimiento.Text = "Fecha de vencimiento de la cuota: " + DateTime.UtcNow.AddDays(30).ToShortDateString();
            lblFormaPago.Text = "Forma de pago: " + forma_pago;
        }
    }
}
