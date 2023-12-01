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
using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubDeportivo
{
    public partial class frmMostrarDeudores : Form
    {
        public frmMostrarDeudores()
        {
            InitializeComponent();
        }

        public void Mostrar_Deudores()
        {
            // Se instancia el objeto de Mysqlconnection
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {

                // Se crea un string para la query
                string query;
                // Se crea la instancia con la conexion
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Se crea la query que es un left join
                query = "SELECT s.nro_socio, s.nombre,s.apellido,MAX(p.vencimiento) AS vencimiento FROM socio AS s LEFT JOIN pagos AS p ON s.nro_socio = p.nro_socio GROUP BY s.nro_socio, s.nombre, s.apellido HAVING MAX(p.vencimiento) < CURDATE() OR MAX(p.vencimiento) IS NULL;";

                // Se instancia el comando con la query y la conexion
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                
                // Comando de tipo text para pasar la query
                comando.CommandType = CommandType.Text;
                // Se abre la conexion y se crea un datareader para leer y se ejecuta
                sqlCon.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvDeudores.Rows.Add();
                        dtgvDeudores.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        dtgvDeudores.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvDeudores.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dtgvDeudores.Rows[renglon].Cells[3].Value = reader.IsDBNull(3) ? "Pago no registrado" : reader.GetDateTime(3).ToString("yyyy-MM-dd");
                    }
                }
                else
                {
                    MessageBox.Show("No hay deudores el dia de hoy");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            this.Close();
            principal.Show();

        }

        private void frmMostrarDeudores_Load(object sender, EventArgs e)
        {
            Mostrar_Deudores();
        }
    }
}
