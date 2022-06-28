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
    public class AD_Camiones
    {
        public static DataTable ObtenerCamionXPatente(string patente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT c.Patente, c.Modelo, m.Nombre FROM Camiones c " +
                                  "JOIN Marcas m on(c.Marca = m.Id_Marca) WHERE c.Patente = @patente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", patente);
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

        public static DataTable ObtenerListadoCamiones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                //string consulta = "SELECT * FROM Camiones";
                string consulta = "SELECT c.Patente, c.Modelo, m.Nombre as Marca " +
                                "FROM Camiones c " +
                                "JOIN Marcas m on(c.Marca = m.Id_Marca)";

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
        public static bool AgregarCamion(Camion ca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Camiones(Patente, Modelo, Marca) VALUES(@patente, @modelo, @marca)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", ca.Patente);
                cmd.Parameters.AddWithValue("@modelo", ca.Modelo);
                cmd.Parameters.AddWithValue("@marca", ca.Marca);
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
        public static bool ActualizarCamion(Camion ca)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Camiones SET Patente = @patente, Modelo = @modelo, Marca = @marca WHERE Patente like @patente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", ca.Patente);
                cmd.Parameters.AddWithValue("@modelo", ca.Modelo);
                cmd.Parameters.AddWithValue("@marca", ca.Marca);


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

        public static Camion ObtenerCamion(string patente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Camion ca = new Camion();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Camiones WHERE Patente LIKE @patente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", patente);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    ca.Patente = dr["Patente"].ToString();
                    ca.Modelo = dr["Modelo"].ToString();
                    ca.Marca = int.Parse(dr["Marca"].ToString());

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
            return ca;
        }
        public static bool BorrarCamion(Camion ca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Camiones WHERE Patente like @patente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", ca.Patente);


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

        public static DataTable ObtenerListadoCamionesXMarca(string marca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                //string consulta = "SELECT * FROM Camiones";
                string consulta = "SELECT c.Patente, c.Modelo, m.Nombre as Marca " +
                                "FROM Camiones c " +
                                "JOIN Marcas m on(c.Marca = m.Id_Marca) " +
                                "WHERE m.Nombre like @marca + '%'";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marca", marca);


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

        public static DataTable ObtenerListadoCamionesXModelo(string modelo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                //string consulta = "SELECT * FROM Camiones";
                string consulta = "SELECT c.Patente, c.Modelo, m.Nombre as Marca " +
                                "FROM Camiones c " +
                                "JOIN Marcas m on(c.Marca = m.Id_Marca) " +
                                "WHERE c.Modelo like @modelo + '%'";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@modelo", modelo);


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

    }
}
