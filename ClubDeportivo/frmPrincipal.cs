using ClubDeportivo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmPrincipal : Form
    {

        // Constructor frm principal
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Trae la clase estatica
            
            lblIngreso.Text = "Usuario: " + UsuarioActual.Usuario + " (" + UsuarioActual.Rol + ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Ana
        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            frmInscribirSocio InscribirSocio = new frmInscribirSocio();
            this.Hide();
            InscribirSocio.Show();
        }

        // Emi
        private void btnDeudores_Click(object sender, EventArgs e)
        {
            frmMostrarDeudores Deudores = new frmMostrarDeudores();
            this.Hide();
            Deudores.Show();
        }

        // Emi
        private void btnCobroCuota_Click(object sender, EventArgs e)
        {
            frmPagarCuota CobrarCuota = new frmPagarCuota();
            this.Close();
            CobrarCuota.Show();
        }


        // Euge
        private void btnEntregaCarnet_Click(object sender, EventArgs e)
        {
            frmEntregarCarnet EntregarCarnet = new frmEntregarCarnet();
            this.Close();
            EntregarCarnet.Show();
        }

        // Ana
        private void btnRegistrarNo_Socio_Click(object sender, EventArgs e)
        {
            frmInscribirNoSocio No_Socio = new frmInscribirNoSocio();
            this.Close();
            No_Socio.Show();
        }
    }
}
