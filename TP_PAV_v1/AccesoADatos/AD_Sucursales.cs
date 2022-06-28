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
    public class AD_Sucursales
    {
        public static DataTable ObtenerListadoSucursales()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT s.Nro_Sucursal, p.nombre as Id_Provincia FROM Sucursales s " +
                    "JOIN Provincia p on(s.Id_Provincia = p.Id_Prov)";


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
        public static bool AgregarSucursalABD(Sucursal sucur)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Sucursales (Nro_Sucursal, Id_Provincia) VALUES(@nroSucursal, @idProvincia)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroSucursal", sucur.NroSucursal);
                cmd.Parameters.AddWithValue("@idProvincia", sucur.IdProvinciaSucursal);
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
        public static Sucursal ObtenerSucursal(int nroSucursal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Sucursal s = new Sucursal();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Sucursales WHERE Nro_Sucursal like @nroSucursal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroSucursal", nroSucursal);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    s.NroSucursal = int.Parse(dr["Nro_Sucursal"].ToString());
                    s.IdProvinciaSucursal = int.Parse(dr["Id_Provincia"].ToString());

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

            return s;

        }
        public static bool ActualizarSucursal(Sucursal sucur)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Sucursales SET Id_Provincia = @idProvincia WHERE Nro_Sucursal like @nroSucursal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroSucursal", sucur.NroSucursal);
                cmd.Parameters.AddWithValue("@idProvincia", sucur.IdProvinciaSucursal);
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
        public static void EliminarSucursal(string NroSucursal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Sucursales WHERE Nro_Sucursal LIKE @nroSucursal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroSucursal", NroSucursal);
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
        public static DataTable ObtenerComboProvincia()
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

                DataTable Tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Tabla);

                return Tabla;
            
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
