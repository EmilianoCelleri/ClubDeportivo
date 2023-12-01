using ClubDeportivo.Entidades;
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
    public partial class frmInscribirNoSocio : Form
    {
        public frmInscribirNoSocio()
        {
            InitializeComponent();
        }

        private void Limpiar_Form()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDni.Text = "";
            txtNombre.Focus();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar_Form();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            this.Close();
            principal.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtDni.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string respuesta;

                E_NoSocio no_socio = new E_NoSocio();
                no_socio.nombre = txtNombre.Text;
                no_socio.apellido = txtApellido.Text;
                no_socio.direccion = txtDireccion.Text;
                no_socio.telefono = Convert.ToInt32(txtTelefono.Text);
                no_socio.email = txtEmail.Text;
                no_socio.dni = Convert.ToInt32(txtDni.Text);

                Clases.Administracion no_socios = new Clases.Administracion();

                respuesta = no_socios.Nuevo_NoSocio(no_socio);

                bool esnumero = int.TryParse(respuesta, out int codigo);

                if (esnumero)
                {
                    if (codigo == 1)
                    {

                        MessageBox.Show("El No Socio ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se registro a: " + no_socio.nombre + " Como No Socio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        Limpiar_Form();
                    }
                }

            }
        }
    }
}
