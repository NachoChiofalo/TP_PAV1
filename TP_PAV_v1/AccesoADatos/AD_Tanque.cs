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
    public class AD_Tanque
    {
        public static bool AgregarTanquesABD(Tanques t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "insert into Tanques(CUIT, Nro_Tanque, Vol_Maximo, Vol_Minimo, Cod_Tipo_Combustible) values(@cuit, @nroTanque, @volMax, @volMin, @codTipoCombustible)";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@cuit", t.CUITTanque);
                cmd.Parameters.AddWithValue("@nroTanque", t.NroTanques);
                cmd.Parameters.AddWithValue("@volMax", t.VolMaxTanque);
                cmd.Parameters.AddWithValue("@volMin", t.VolMinTanque);
                cmd.Parameters.AddWithValue("@codTipoCombustible", t.CodTipoCombustibleTanque);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Error al agregar Tanques");
            }
            finally
            {
                cn.Close();
            }
            return result;
        }

        public static DataTable ObtenerListadoTanques()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "select * from tanques";

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
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static Tanques ObtenerTanques(string cuit, int nroTanque)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Tanques t = new Tanques();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select * from Tanques where (CUIT like @cuit and Nro_Tanque like @nroTanque)";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@cuit", cuit);
                cmd.Parameters.AddWithValue("@nroTanque", nroTanque);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    t.CUITTanque = dr["CUIT"].ToString();
                    t.NroTanques = int.Parse(dr["Nro_Tanque"].ToString());
                    t.VolMaxTanque = int.Parse(dr["Vol_Maximo"].ToString());
                    t.VolMinTanque = int.Parse(dr["Vol_Minimo"].ToString());
                    t.CodTipoCombustibleTanque = int.Parse(dr["Cod_Tipo_Combustible"].ToString());
                }


            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return t;
        }

        public static bool ActualizarTanqueBD(Tanques t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "update Tanques set CUIT = @cuit, Nro_Tanque = @nroTanque, Vol_Maximo = @volMax, Vol_Minimo = @volMin, Cod_Tipo_Combustible = @codTipoCombustible where CUIT like @cuit and Nro_Tanque like @nroTanque";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@cuit", t.CUITTanque);
                cmd.Parameters.AddWithValue("@nroTanque", t.NroTanques);
                cmd.Parameters.AddWithValue("@volMax", t.VolMaxTanque);
                cmd.Parameters.AddWithValue("@volMin", t.VolMinTanque);
                cmd.Parameters.AddWithValue("@codTipoCombustible", t.CodTipoCombustibleTanque);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Error al actualizar tanques");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool EliminarTanques(Tanques t)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "delete from Tanques where (Nro_Tanque like @nroTanque and CUIT like @cuit)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuit", t.CUITTanque);
                cmd.Parameters.AddWithValue("@nroTanque", t.NroTanques);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR Al intentar Borrar!");
            }
            finally
            {
                cn.Close();
            }

            return resultado;

        }

    }
}
