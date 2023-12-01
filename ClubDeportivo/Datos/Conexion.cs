using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {
            bool correcto = false;
            int mensaje;

            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";

            while (correcto != true)
            {
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Servidor", "Acceso a Base de Datos");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Puerto", "Acceso a Base de Datos");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Usuario", "Acceso a Base de Datos");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Clave", "Acceso a Base de Datos");

                mensaje = (int)MessageBox.Show("Su ingreso: SERVIDOR: " + T_servidor + " PUERTO: " + T_puerto + " USUARIO: " + T_usuario + " CLAVE: " + T_clave, "Compruebe los datos de conexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               
                if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("Ingrese nuevamente los datos");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }

            }

            this.baseDatos = "ClubDeportivo";
            this.servidor = T_servidor;
            this.puerto = T_puerto;
            this.usuario = T_usuario;
            this.clave = T_clave;
        }


        // METODOS crear conexion
        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new();
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch (Exception)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        // METODO crear instancia

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }

            return con;
        }
    }
}
