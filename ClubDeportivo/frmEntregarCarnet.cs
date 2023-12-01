using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    public partial class frmEntregarCarnet : Form
    {
        frmCarnet Carnet = new frmCarnet();

        public frmEntregarCarnet()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            this.Close();
            principal.Show();

        }

        private void btnEmitirCarnet_Click(object sender, EventArgs e)
        {


            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                string query;

                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select nombre, apellido, documento from socio where Documento = " + txtDniSocio.Text;

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader;

                reader = comando.ExecuteReader();
                // Si tiene filas
                if (reader.HasRows)
                {
                    reader.Read();

                    Carnet.nombre = reader.GetString(0);
                    Carnet.apellido = reader.GetString(1);
                    Carnet.dni = Convert.ToInt32(reader.GetString(2));
                    this.Close();
                    Carnet.Show();

                }
                else
                {
                    MessageBox.Show("Socio no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) {sqlCon.Close();}
            }
            

        }
    }
}
