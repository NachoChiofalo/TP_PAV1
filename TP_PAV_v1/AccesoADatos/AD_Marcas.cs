using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_v1.Entidades;

namespace TP_PAV_v1.AccesoADatos
{
    public class AD_Marcas
    {
        public static DataTable ObtenerMarcas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Marcas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool AgregarMarca(Marca mar)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Marcas(Nombre) VALUES(@nombre)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", mar.NombreMarca);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }


            return result;
        }

        public static bool ActualizarMarca(Marca mar)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Marcas SET Nombre = @nombre WHERE Id_Marca like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", mar.IdMarca);
                cmd.Parameters.AddWithValue("@nombre", mar.NombreMarca);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return result;
        }
        public static bool EstaReferenciada(Marca mar)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Camiones WHERE Marca = @idMarca";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idMarca", mar.IdMarca);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader rd = cmd.ExecuteReader();


                if (rd.Read())
                {
                    resultado = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;

        }
        public static bool BorrarMarca(Marca mar)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE from Marcas WHERE Id_Marca like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", mar.IdMarca);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return result;
        }
        public static Marca ObtenerMarca(string idMarca)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Marca mar = new Marca();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Marcas where Id_Marca like @idMarca";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idMarca", idMarca);


                cmd.CommandType = CommandType.Text; // significa que escribo a mano la consulta SQL 
                cmd.CommandText = consulta; // a mi coman le agrego el comandtext que es consulta

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    mar.IdMarca = int.Parse(dr["Id_Marca"].ToString());

                    mar.NombreMarca = dr["Nombre"].ToString();

                }


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

                cn.Close();
            }
            return mar;
        }
    }
}
