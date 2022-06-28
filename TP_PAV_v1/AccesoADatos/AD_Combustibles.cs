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
    public class AD_Combustibles
    {
        public static DataTable ObtenerCombustibles()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT c.Cod_Combustible, c.nombre, t.nombre as Tipo FROM Combustible c JOIN Tipo_Combustible t ON (c.Cod_tipo_combustible = t.Cod_Tipo_Combustible )";

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

        public static bool AgregarCombustibleABD(Combustible combust)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Combustible (nombre, Cod_tipo_combustible) VALUES (@nombre, @codTipo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", combust.nombre);
                cmd.Parameters.AddWithValue("@codTipo", combust.Cod_Tipo_Combustible);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
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

        public static Combustible ObtenerCombustible(string cod)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Combustible combust = new Combustible();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Combustible WHERE Cod_Combustible like @cod";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    combust.nombre = dr["nombre"].ToString();
                    combust.Cod_Combustible = int.Parse(dr["Cod_Combustible"].ToString());
                    combust.Cod_Tipo_Combustible = int.Parse(dr["Cod_tipo_combustible"].ToString());
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


            return combust;
        }

        public static void EliminarCombustible(string c)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Combustible WHERE Cod_Combustible like @cod";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", int.Parse(c));

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

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

        public static bool ActualizarCombustible(Combustible combust)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Combustible SET nombre = @nom, Cod_tipo_combustible = @codTipo WHERE Cod_Combustible like @cod";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", combust.Cod_Combustible);
                cmd.Parameters.AddWithValue("@nom", combust.nombre);
                cmd.Parameters.AddWithValue("@codTipo", combust.Cod_Tipo_Combustible);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;



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
    }
}
