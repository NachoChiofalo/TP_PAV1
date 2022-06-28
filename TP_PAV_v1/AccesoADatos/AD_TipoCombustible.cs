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
    internal class AD_TipoCombustible
    {
        public static DataTable ObtenerCombustibleXCodigo(int codigo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Tipo_Combustible WHERE Cod_Tipo_Combustible = @codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codigo);
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

        public static DataTable ObtenerTiposCombustibles()
        {
            
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Tipo_Combustible";

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

        public static bool AgregarTipoCombustibleABD(TipoCombustible comb)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            // validar que no existe en la grilla

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Tipo_Combustible (nombre) VALUES (@nombre)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", comb.nombre);
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

        public static TipoCombustible ObtenerTipoCombustible(string cod)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            TipoCombustible comb = new TipoCombustible();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Tipo_Combustible WHERE Cod_Tipo_Combustible like @cod";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    comb.nombre = dr["nombre"].ToString();
                    comb.Cod_Tipo_Combustible = int.Parse(dr["Cod_Tipo_Combustible"].ToString());

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


            return comb;
        }

        public static void EliminarTipoCombustible(string c)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Tipo_Combustible WHERE Cod_Tipo_Combustible like @cod";

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

        public static bool ActualizarTipoCombustible(TipoCombustible comb)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Tipo_Combustible SET nombre = @nom WHERE Cod_Tipo_Combustible like @cod";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", comb.Cod_Tipo_Combustible);
                cmd.Parameters.AddWithValue("@nom", comb.nombre);

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

        public static bool EstaReferenciada(TipoCombustible comb)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Combustible WHERE Cod_tipo_combustible = @cod";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", comb.Cod_Tipo_Combustible);
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
    }

}
