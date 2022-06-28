using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_v1.Entidades;

namespace TP_PAV_v1
{
    public partial class ABMLocalidad : Form
    {
        public ABMLocalidad()
        {
            InitializeComponent();
        }

        private void ABMLocalidad_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboProvincia();
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            CargarGrilla();
        }

        private void CargarComboProvincia()
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

                cmbProvincia.DataSource = Tabla;
                cmbProvincia.DisplayMember = "nombre";
                cmbProvincia.ValueMember = "Id_Prov";
                cmbProvincia.SelectedIndex = -1;
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

        private void LimpiarCampos()
        {
            txtIdLocalidad.Text = "";
            txtNombreLocalidad.Text = "";
            cmbProvincia.Text = "";
            txtIdLocalidad.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtIdLocalidad.Enabled = true;
        }

        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Localidad";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tabla);  // ejecuta la consulta y lo carga en la tabla (DataTable tabla)

                grillaLocalidad.DataSource = tabla;

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

        private Localidad ObtenerDatosLocalidad()
        {
            Localidad l = new Localidad();
            l.IdDeLaLocalidad = int.Parse(txtIdLocalidad.Text);
            l.NombreDeLaLocalidad = txtNombreLocalidad.Text.Trim();
            l.ProvinciaDeLaLocalidad = (int)(cmbProvincia.SelectedValue);

            if (txtIdLocalidad.Text.Equals(""))
            {
                l.IdDeLaLocalidad = 0;
            }
            else
            {
                l.IdDeLaLocalidad = int.Parse(txtIdLocalidad.Text);
            }
            return l;
        }

        private bool CamposCompletos()
        {
            bool resultado = false;
            if (txtIdLocalidad.Text.Equals("") || txtNombreLocalidad.Text.Equals("") || cmbProvincia.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos!!");
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        private bool AgregarLocalidadABD(Localidad l)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Localidad (Id_Localidad, nombre, Id_Prov) VALUES(@idLocalidad, @nombre, @provincia)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idLocalidad", l.IdDeLaLocalidad);
                cmd.Parameters.AddWithValue("@nombre", l.NombreDeLaLocalidad);
                cmd.Parameters.AddWithValue("@provincia", l.ProvinciaDeLaLocalidad);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Localidad en la BD");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                Localidad l = ObtenerDatosLocalidad();
                bool existe = ExisteEnGrilla(l.IdDeLaLocalidad);
                if (!existe)
                {
                    bool resultado = AgregarLocalidadABD(l);
                    if (resultado)
                    {
                        MessageBox.Show("Nueva Localidad agregada con exito!");
                        LimpiarCampos();
                        CargarComboProvincia();
                        CargarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("Error! La Localidad ya existe");
                    LimpiarCampos();
                    txtIdLocalidad.Focus();
                }

            }
        }
        private bool ExisteEnGrilla(int idLocalidad)
        {
            bool resultado = false;
            for (int i = 0; i < grillaLocalidad.Rows.Count; i++)
            {
                if (grillaLocalidad.Rows[i].Cells["idLocalidad"].Value.Equals(idLocalidad))
                {
                    resultado = true;
                    break;
                }

            }
            return resultado;
        }
 
        private Localidad ObtenerLocalidad(int idLoc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Localidad l = new Localidad();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Localidad WHERE Id_Localidad LIKE @idLocalidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idLocalidad", idLoc);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader(); // lee el resultado

                if (dr != null && dr.Read())
                {
                    l.IdDeLaLocalidad = int.Parse(dr["Id_Localidad"].ToString());
                    l.NombreDeLaLocalidad = dr["nombre"].ToString();
                    l.ProvinciaDeLaLocalidad = int.Parse(dr["Id_Prov"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos de la Localidad");
            }
            finally
            {
                cn.Close();
            }

            return l;
        }

        private void grillaLocalidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            txtIdLocalidad.Enabled = false;
            DataGridViewRow filaSeleccionada = grillaLocalidad.Rows[indice];
            int idLoc = int.Parse(filaSeleccionada.Cells["idLocalidad"].Value.ToString());
            try
            {
                Localidad l = ObtenerLocalidad(idLoc);
                LimpiarCampos();
                CargarCampos(l);

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los datos de la Localidad!");
            }
        }

        private void CargarCampos(Localidad l)
        {
            txtIdLocalidad.Text = l.IdDeLaLocalidad.ToString();
            txtNombreLocalidad.Text = l.NombreDeLaLocalidad;
            cmbProvincia.Text = l.ProvinciaDeLaLocalidad.ToString();
        }

        private bool ActualizarLocalidad(Localidad loc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            txtIdLocalidad.Enabled = true;
            txtIdLocalidad.Focus();
            btnGuardar.Enabled = true;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Localidad SET nombre = @nombre, Id_Prov = @idProvincia WHERE Id_Localidad LIKE @idLocalidad ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idLocalidad", loc.IdDeLaLocalidad);
                cmd.Parameters.AddWithValue("@nombre", loc.NombreDeLaLocalidad);
                cmd.Parameters.AddWithValue("@idProvincia", loc.ProvinciaDeLaLocalidad);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Localidad l = ObtenerDatosLocalidad();
            bool resultado = ActualizarLocalidad(l);
            if (resultado)
            {
                MessageBox.Show("Localidad modificada con exito!");
                LimpiarCampos();
                CargarComboProvincia();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al actualizar Localidad!");
            }
        }

        private void EliminarProvincia(string idLocalidad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Localidad WHERE Id_Localidad LIKE @idLocalidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idLocalidad", idLocalidad);
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                string idLocalidad = txtIdLocalidad.Text;
                EliminarProvincia(idLocalidad);
                MessageBox.Show("La Localidad fue eliminada con exito!");
                LimpiarCampos();
                CargarGrilla();
                btnGuardar.Enabled = true;
                btnBorrar.Enabled = false;
                btnActualizar.Enabled = false;
                txtIdLocalidad.Enabled = true;
                txtIdLocalidad.Focus();
            }
        }
    }
}
