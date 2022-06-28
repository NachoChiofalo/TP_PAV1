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
    public class AD_Turnos
    {
        public static DataTable ObtenerListadoTurnos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Turnos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tabla);  

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

        public static bool AgregarTurnoABD(Turno t)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Turnos (Cod_Turno, descriptor) VALUES(@idTurno, @descriptor)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idTurno", t.IdDelTurno);
                cmd.Parameters.AddWithValue("@descriptor", t.DescripcionTurno);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar Turno en la BD");
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static Turno ObtenerTurno(int idTurno)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Turno t = new Turno();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Turnos WHERE Cod_Turno LIKE @idTurno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idTurno", idTurno);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader(); // lee el resultado

                if (dr != null && dr.Read())
                {
                    t.IdDelTurno = int.Parse(dr["Cod_Turno"].ToString());
                    t.DescripcionTurno = dr["descriptor"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos del Turno");
            }
            finally
            {
                cn.Close();
            }

            return t;
        }

        public static bool ActualizarTurno(Turno turno)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Turnos SET descriptor = @desc WHERE Cod_Turno LIKE @codTurno ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codTurno", turno.IdDelTurno);
                cmd.Parameters.AddWithValue("@desc", turno.DescripcionTurno);

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

        public static void EliminarTurno(string idTurno)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Turnos WHERE Cod_Turno LIKE @idTurno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idTurno", idTurno);
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
