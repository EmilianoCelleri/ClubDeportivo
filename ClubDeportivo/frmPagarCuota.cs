using ClubDeportivo.Datos;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubDeportivo
{
    public partial class frmPagarCuota : Form
    {

        frmComprobantePago Comprobante = new frmComprobantePago();
        public frmPagarCuota()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            this.Close();
            principal.Show();

        }

        private void frmPagarCuota_Load(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {

                if (txtNroSocio.Text == "")
                {
                    MessageBox.Show("Complete el campo Numero de Socio");
                }
                else
                {

                    //Comprobar si la cuota ya esta paga

                    string query;
                    sqlCon = Conexion.getInstancia().CrearConexion();
                    query = "SELECT s.nro_socio, s.nombre, s.apellido, MAX(p.vencimiento) AS vencimiento FROM socio AS s LEFT JOIN pagos AS p ON s.nro_socio = p.nro_socio WHERE s.nro_socio = " + txtNroSocio.Text + " GROUP BY s.nro_socio, s.nombre, s.apellido HAVING MAX(p.vencimiento) < CURDATE() OR MAX(p.vencimiento) IS NULL;";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.CommandType = CommandType.Text;
                    sqlCon.Open();

                    MySqlDataReader reader;
                    reader = comando.ExecuteReader();

                    if (reader.HasRows) //Si tiene filas quiere decir que debe cuota
                    {
                        if (optEfectivo.Checked == true)
                        {
                            reader.Close();
                            query = "INSERT INTO pagos(nro_socio, fecha_pago, vencimiento)VALUES(" + txtNroSocio.Text + ",NOW(),DATE_ADD(NOW(), INTERVAL 30 DAY));";
                            MySqlCommand comandoInsert = new MySqlCommand(query, sqlCon);
                            comandoInsert.CommandType = CommandType.Text;
                            comandoInsert.ExecuteNonQuery();
                            MessageBox.Show("Pago registrado correctamente");

                            Comprobante.nro_socio = txtNroSocio.Text;
                            Comprobante.forma_pago = "Efectivo";
                            this.Close();
                            Comprobante.Show();
                        }
                        else if (optTarjeta.Checked == true)
                        {
                            reader.Close();
                            query = "INSERT INTO pagos(nro_socio, fecha_pago, vencimiento)VALUES(" + txtNroSocio.Text + ",NOW(),DATE_ADD(NOW(), INTERVAL 30 DAY));";
                            MySqlCommand comandoInsert = new MySqlCommand(query, sqlCon);
                            comandoInsert.CommandType = CommandType.Text;
                            comandoInsert.ExecuteNonQuery();
                            MessageBox.Show("Pago registrado correctamente");

                            Comprobante.nro_socio = txtNroSocio.Text;
                            Comprobante.forma_pago = "Tarjeta";
                            this.Close();
                            Comprobante.Show();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione metodo de pago");
                        }


                    }
                    else
                    {
                        MessageBox.Show("El socio no debe cuotas");
                    }
                }
            }




            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
        }
    }
}
