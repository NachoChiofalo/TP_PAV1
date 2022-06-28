using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_v1.AccesoADatos
{
    public class AD_Remitos
    {
        public static bool AltaNuevoRemito(int nroRemito, DateTime fecha,int cuit, string patente, string legajo, int id_sucursal, int id_provincia, int precioTotal, List<int> litros, List<int> precioSubtotal, List<int> CodigosCombustible)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            
            try
            {

                int identRemito = ObtenerUltimoIdentRemitos();

                SqlCommand cmd = new SqlCommand();


                string consulta = "INSERT INTO Remitos values(@fecha, @cuit, @patente, @legajo,@id_sucursal,@id_provincia, @total)";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@cuit", cuit);
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.Parameters.AddWithValue("@id_sucursal", id_sucursal);
                cmd.Parameters.AddWithValue("@id_provincia", id_provincia);
                cmd.Parameters.AddWithValue("@total", precioTotal);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                objTransaccion = cn.BeginTransaction("AltaDeRemito");

                cmd.Transaction = objTransaccion;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

               
                for (int i = 0; i < CodigosCombustible.Count; i++)
                {
                    string consultaDetalleRemito = "INSERT INTO DetalleRemito values(@nroremito, @fecha, @codTipoCombustible, @litros, @precioSubtotal)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nroremito", identRemito);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@codTipoCombustible", CodigosCombustible[i]);
                    cmd.Parameters.AddWithValue("@litros", litros[i]);
                    cmd.Parameters.AddWithValue("@precioSubtotal", precioSubtotal[i]);
                    cmd.CommandText = consultaDetalleRemito;
                    cmd.ExecuteNonQuery();
                }

                objTransaccion.Commit();
                return true;


            }
            catch (Exception)
            {
                objTransaccion.Rollback();
                return false;

            }
            finally
            {
                cn.Close();
            }

        }



        public static int ObtenerUltimoIdentRemitos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT IDENT_CURRENT ('Remitos') + 1";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = int.Parse(cmd.ExecuteScalar().ToString());
                return resultado;


            }
            catch (Exception)
            {
                return 0;

            }
            finally
            {
                cn.Close();
            }

        }




    }
}

