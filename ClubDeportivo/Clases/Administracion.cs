using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Clases
{
    internal class Administracion
    {
        public string Nuevo_Socio(E_Socio socio)
        {
            string? salida;

            // Crea la instancia de MYsql
            MySqlConnection sqlCon = new MySqlConnection();
            
            try
            {
                
                // Se crea la conexion y la instancia
                sqlCon = Conexion.getInstancia().CrearConexion();
                
                // Se instancia un objeto de la clase Mysqlcommand con los argumentos del SP Nuevo Socio y la conexion
                MySqlCommand comando = new MySqlCommand("Nuevo_Socio", sqlCon);
                
                // Tipo de comando Stored Procedure
                comando.CommandType = CommandType.StoredProcedure;


                // Se agregan los parametros de los txt box
                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = socio.nombre;
                comando.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = socio.apellido;
                comando.Parameters.Add("Direccion", MySqlDbType.VarChar).Value = socio.direccion;
                comando.Parameters.Add("Telefono", MySqlDbType.Int32).Value = socio.telefono;
                comando.Parameters.Add("Email", MySqlDbType.VarChar).Value = socio.email;
                comando.Parameters.Add("Dni", MySqlDbType.Int32).Value = socio.dni;


                MySqlParameter ParCodigo = new MySqlParameter();
                
                
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();

                // Ejecuta la Query
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;

        }

        public string Nuevo_NoSocio(E_NoSocio noSocio)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Nuevo_NoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = noSocio.nombre;
                comando.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = noSocio.apellido;
                comando.Parameters.Add("Direccion", MySqlDbType.VarChar).Value = noSocio.direccion;
                comando.Parameters.Add("Telefono", MySqlDbType.Int32).Value = noSocio.telefono;
                comando.Parameters.Add("Email", MySqlDbType.VarChar).Value = noSocio.email;
                comando.Parameters.Add("Dni", MySqlDbType.Int32).Value = noSocio.dni;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;
        }
    }

}

