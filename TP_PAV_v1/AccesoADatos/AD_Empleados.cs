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
    public class AD_Empleados
    {
        public static DataTable ObtenerEmpleadoXLegajo(string legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Empleados WHERE Legajo = @legajo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);
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

        public static DataTable ObtenerListadoEmpleados()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = " SELECT e.Legajo, e.Nombre, e.Apellido, e.CUIL,  td.nombre AS 'Tipo_Documento', " +
                    "e.Nro_Documento, b.nombre AS 'Id_Barrio', e.Calle, e.Nro_Calle, e.Fecha_Ingreso FROM Empleados e " +
                    "JOIN Barrio b ON (e.Id_Barrio = b.Id_Barrio) JOIN Tipo_Documento td ON (e.Tipo_Documento = td.Id_Tipo_Documento)";

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


        public static bool AltaEmpleado(Empleado emp)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Empleados(Nombre, Apellido, CUIL, Nro_Documento, Tipo_Documento, Id_Barrio,  Calle, Nro_Calle, Fecha_Ingreso) VALUES(@Nombre, @Apellido, @CUIL, @Nro_Documento, @Tipo_Documento, @Id_Barrio,  @Calle, @Nro_Calle, @Fecha_Ingreso)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", emp.Apellido);
                cmd.Parameters.AddWithValue("@CUIL", emp.CUIL);
                cmd.Parameters.AddWithValue("@Nro_Documento", emp.Documento);
                cmd.Parameters.AddWithValue("@Tipo_Documento", emp.TipoDocumento);
                cmd.Parameters.AddWithValue("@Id_Barrio", emp.IdBarrio);
                cmd.Parameters.AddWithValue("@Calle", emp.Calle);
                cmd.Parameters.AddWithValue("@Nro_Calle", emp.NumeroCalle);
                cmd.Parameters.AddWithValue("@Fecha_Ingreso", emp.FechaIngreso);


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

        public static Empleado ObtenerEmpleado(string legajo)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            Empleado emp = new Empleado();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Empleados WHERE Legajo LIKE @Legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Legajo", legajo);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;


                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    emp.Nombre = dr["Nombre"].ToString();
                    emp.Apellido = dr["Apellido"].ToString();
                    emp.FechaIngreso = DateTime.Parse(dr["Fecha_Ingreso"].ToString());
                    emp.CUIL = int.Parse(dr["CUIL"].ToString());
                    emp.TipoDocumento = int.Parse(dr["Tipo_Documento"].ToString());
                    emp.Documento = dr["Nro_Documento"].ToString();
                    emp.IdBarrio = int.Parse(dr["Id_Barrio"].ToString());
                    emp.Calle = dr["Calle"].ToString();
                    emp.NumeroCalle = int.Parse(dr["Nro_Calle"].ToString());
                    emp.Legajo = int.Parse(dr["Legajo"].ToString());
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


            return emp;

        }

        public static bool ModificarEmpleado(Empleado emp)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Empleados SET Nombre = @Nombre, Apellido = @Apellido, CUIL = @CUIL, Nro_Documento = @Nro_Documento, " +
                    "Tipo_Documento = @Tipo_Documento, Id_Barrio = @Id_Barrio, Calle = @Calle, " +
                    "Nro_Calle = @Nro_Calle, Fecha_Ingreso = @Fecha_Ingreso WHERE Legajo LIKE @Legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", emp.Apellido);
                cmd.Parameters.AddWithValue("@CUIL", emp.CUIL);
                cmd.Parameters.AddWithValue("@Nro_Documento", emp.Documento);
                cmd.Parameters.AddWithValue("@Tipo_Documento", emp.TipoDocumento);
                cmd.Parameters.AddWithValue("@Id_Barrio", emp.IdBarrio);
                cmd.Parameters.AddWithValue("@Calle", emp.Calle);
                cmd.Parameters.AddWithValue("@Nro_Calle", emp.NumeroCalle);
                cmd.Parameters.AddWithValue("@Fecha_Ingreso", emp.FechaIngreso);
                cmd.Parameters.AddWithValue("@Legajo", emp.Legajo);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

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

        public static bool EliminarEmpleado(Empleado emp)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Empleados WHERE Legajo LIKE @Legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Legajo", emp.Legajo);


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
