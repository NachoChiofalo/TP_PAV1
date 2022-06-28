using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_v1.Entidades;

namespace TP_PAV_v1.AccesoADatos
{
    public class AD_Provincias
    {
        public static DataTable ObtenerListadoProvincias()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Provincia";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tabla);  // ejecuta la consulta y lo carga en la tabla (DataTable tabla)

                return tabla;
                //grillaProvincia.DataSource = tabla;

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();

            }
        }
        public static bool AgregarProvinciaABD(Provincias p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Provincia (Id_Prov, nombre, Cod_Postal) VALUES(@idProvincia, @nombre, @codPostal)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProvincia", p.IdDeLaProvincia);
                cmd.Parameters.AddWithValue("@nombre", p.NombreDeLaProvincia);
                cmd.Parameters.AddWithValue("@codPostal", p.CodigoPostalDeLaProvincia);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar Provincia en la BD");
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }
        public static Provincias ObtenerProvincia(int idProv)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Provincias p = new Provincias();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Provincia WHERE Id_Prov LIKE @idProvincia";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProvincia", idProv);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader(); // lee el resultado

                if (dr != null && dr.Read())
                {
                    p.IdDeLaProvincia = int.Parse(dr["Id_Prov"].ToString());
                    p.NombreDeLaProvincia = dr["nombre"].ToString();
                    p.CodigoPostalDeLaProvincia = dr["Cod_Postal"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos de la Provincia");
            }
            finally
            {
                cn.Close();
            }

            return p;
        }

        public static bool ActualizarProvincia(Provincias prov)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Provincia SET nombre = @nombre, Cod_Postal = @codPostal WHERE Id_Prov LIKE @idProvincia ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProvincia", prov.IdDeLaProvincia);
                cmd.Parameters.AddWithValue("@nombre", prov.NombreDeLaProvincia);
                cmd.Parameters.AddWithValue("@codPostal", prov.CodigoPostalDeLaProvincia);
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
        public static void EliminarProvincia(string idProvincia)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Provincia WHERE Id_Prov LIKE @idProvincia";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProvincia", idProvincia);
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

    }
}
