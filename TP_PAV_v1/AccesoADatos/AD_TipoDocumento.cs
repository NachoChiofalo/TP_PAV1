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
    public class AD_TipoDocumento
    {

        public static DataTable ObtenerTiposDocumento()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {


                SqlCommand cmd = new SqlCommand();

                string consulta = "GetTiposDocumentos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable ObtenerListadoTiposDocumento()
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = " SELECT * FROM Tipo_Documento ";
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

        public static bool AltaTipoDocumento(TipoDocumento td)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Tipo_Documento VALUES(@Nombre)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", td.NombreTipoDocumento);



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

        public static TipoDocumento ObtenerTipoDocumento(string idTipoDoc)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            TipoDocumento td = new TipoDocumento();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Tipo_Documento WHERE Id_Tipo_Documento LIKE @IdTipoDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdTipoDoc", idTipoDoc);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                // objeto del tipo sql data reader -> para leer
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    td.NombreTipoDocumento = dr["nombre"].ToString();
                    td.IdTipoDocumento = int.Parse(dr["Id_Tipo_Documento"].ToString());
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


            return td;



        }

        public static bool ModificarTipoDocumento(TipoDocumento td)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Tipo_Documento SET nombre = @Nombre WHERE Id_Tipo_Documento LIKE  @IdTipoDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", td.NombreTipoDocumento);
                cmd.Parameters.AddWithValue("@IdTipoDoc", td.IdTipoDocumento);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                //ejecuta y no quiero ninguna respuesta
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR Al intentar actualizar!");
            }
            finally
            {
                cn.Close();
            }


            return resultado;



        }
        public static bool EliminarTipoDocumento(TipoDocumento td)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Tipo_Documento WHERE Id_Tipo_Documento LIKE @Id_Tipo_Documento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Tipo_Documento", td.IdTipoDocumento);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                //ejecuta y no quiero ninguna respuesta
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
