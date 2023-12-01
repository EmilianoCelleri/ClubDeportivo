using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace ClubDeportivo.Datos
{
    internal class Usuarios
    {
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            
            // Crear un data Reader de Mysql para leer la tabla 
            
            MySqlDataReader resultado;
            
            // Crea la tabla 
            DataTable tabla = new DataTable();

            //Crea la conexion
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                
                // Crea la instancia y la conexion
                sqlCon = Conexion.getInstancia().CrearConexion();

                //LLama al procedimiento almacenado con la conexion
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);


                //Tipo de comando STORED PROCEDURE
                comando.CommandType = CommandType.StoredProcedure;

                //Agregan los parametros 
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;
                //Crea la conexion con SQL
                sqlCon.Open();

                // Carga los datos en la tabla
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

                // Si la conexion quedo abierta la cierra
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
