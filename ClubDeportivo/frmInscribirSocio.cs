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
    public partial class frmInscribirSocio : Form
    {
        public frmInscribirSocio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Limpiar_Form()
        {

            // Boton limpiar form, Blanquea todos los txt box
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDni.Text = "";
            txtNombre.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            //Comprueba si algun txt box esta vacio
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtDni.Text == "")
            {
                // En caso que haya algun txt box vacio manda un msg box
                MessageBox.Show("Debe completar todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                // Si estan todos completos 


                string respuesta;

                // Instancia un objeto de la entidad Socio
                E_Socio socio = new E_Socio();

                // Coloca los atributos de los txt box
                socio.nombre = txtNombre.Text;
                socio.apellido = txtApellido.Text;
                socio.direccion = txtDireccion.Text;
                socio.telefono = Convert.ToInt32(txtTelefono.Text);
                socio.email = txtEmail.Text;
                socio.dni = Convert.ToInt32(txtDni.Text);

                // Se instancia la clase administracion
                Clases.Administracion socios = new Clases.Administracion();

                // Se llama al metodo nuevo_Socio de la clase Administracion con el argumento de un socio
                respuesta = socios.Nuevo_Socio(socio);

                bool esnumero = int.TryParse(respuesta, out int codigo);

                if (esnumero)
                {
                    if (codigo == 1)
                    {

                        // Si el codigo es 1 quiere decir que el socio ya existe
                        MessageBox.Show("El Socio ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Sino se crea el socio
                        MessageBox.Show("Se registro con exito con el codigo Nro " + respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        Limpiar_Form();
                    }
                }

            }
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
    }
}
