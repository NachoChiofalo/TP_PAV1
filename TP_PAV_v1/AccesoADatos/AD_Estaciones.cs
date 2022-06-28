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
    public class AD_Estaciones
    {

        public static DataTable ObtenerEstacionXCuit(int cuit)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT e.CUIT, e.Nombre, e.Nro_Sucursal, p.nombre, p.Id_Prov FROM Estaciones e " +
                                  "JOIN Provincia p on(e.Id_Provincia = p.Id_Prov) WHERE e.CUIT = @cuit";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuit", cuit);
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
        public static bool AgregarEstacionABD(Estacion es)
        { 
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            
            bool result = false;
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "insert into Estaciones(CUIT, Nombre, Nro_Sucursal, Calle, Nro_Calle, Id_Provincia, Legajo_Gerente, Planta) values(@cuit, @nombre, @nroSucursal, @calle, @nroCalle, @idProvincia, @legajo, @planta)";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@cuit", es.CUITEstacion);
                cmd.Parameters.AddWithValue("@nombre", es.NombreEstaciones);
                cmd.Parameters.AddWithValue("@nroSucursal", es.IdSucursalEstacion);
                cmd.Parameters.AddWithValue("@calle", es.CalleEstacion);
                cmd.Parameters.AddWithValue("@nroCalle", es.AlturaEstacion);
                cmd.Parameters.AddWithValue("@idProvincia", es.IdProvinciaEstacion);
                cmd.Parameters.AddWithValue("@legajo", es.LegajoGerenteEstacion);
                cmd.Parameters.AddWithValue("@planta", es.PlantaEstacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar Estaciones");
            }
            finally
            {
                cn.Close();
            }
            return result;
        }



        public static Estacion ObtenerEstacion(string cuit)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Estacion es = new Estacion();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select * from Estaciones where CUIT like @cuit";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@cuit", cuit);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    es.NombreEstaciones = dr["Nombre"].ToString();
                    es.CUITEstacion = dr["CUIT"].ToString();
                    es.IdSucursalEstacion = int.Parse(dr["Nro_Sucursal"].ToString());
                    es.CalleEstacion = dr["Calle"].ToString();
                    es.AlturaEstacion = int.Parse(dr["Nro_Calle"].ToString());
                    es.IdProvinciaEstacion = int.Parse(dr["Id_Provincia"].ToString());
                    es.LegajoGerenteEstacion = dr["Legajo_Gerente"].ToString();
                    es.PlantaEstacion = dr["Planta"].ToString();
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
            return es;
        }

        public static bool ActualizarEstacionBD(Estacion es)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "update Estaciones set CUIT = @cuit, Nombre = @nombre, Nro_Sucursal = @nroSucursal, Calle = @calle, Nro_Calle = @nroCalle, Id_Provincia = @idProvincia, Legajo_Gerente = @legajo, Planta = @planta where CUIT like @cuit";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@cuit", es.CUITEstacion);
                cmd.Parameters.AddWithValue("@nombre", es.NombreEstaciones);
                cmd.Parameters.AddWithValue("@nroSucursal", es.IdSucursalEstacion);
                cmd.Parameters.AddWithValue("@calle", es.CalleEstacion);
                cmd.Parameters.AddWithValue("@nroCalle", es.AlturaEstacion);
                cmd.Parameters.AddWithValue("@idProvincia", es.IdProvinciaEstacion);
                cmd.Parameters.AddWithValue("@legajo", es.LegajoGerenteEstacion);
                cmd.Parameters.AddWithValue("@planta", es.PlantaEstacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Error al actualizar estaciones");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool EliminarEstacion(Estacion es)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "delete from Estaciones where CUIT like @cuit";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuit", es.CUITEstacion);


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

        public static  DataTable ObtenerListadoEstaciones()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "select * from Estaciones";
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
    }
}
