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
    public partial class ABMBarrio : Form
    {
        public ABMBarrio()
        {
            InitializeComponent();
        }

        private void ABMBarrio_Load(object sender, EventArgs e)
        {
            btnActualizarBarrio.Enabled = false;
            btnBorrarBarrio.Enabled = false;
            LimpiarCampos();
            CargarComboLocalidad();
            CargarGrilla();
        }
        private void LimpiarCampos()
        {
            txtIdBarrio.Text = "";
            txtNombre.Text = "";
            cmbIdLocalidad.SelectedIndex = -1;
            txtIdBarrio.Focus();
        }

        private void CargarComboLocalidad()
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

                DataTable Tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Tabla);

                cmbIdLocalidad.DataSource = Tabla;
                cmbIdLocalidad.DisplayMember = "nombre";
                cmbIdLocalidad.ValueMember = "Id_Localidad";
                cmbIdLocalidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT b.Id_Barrio, b.nombre, l.nombre as Id_Localidad FROM Barrio b " +
                    "JOIN Localidad l on (b.Id_Localidad = l.Id_Localidad)";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                gdrBarrios.DataSource = tabla;
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

       

        private bool ExisteEnGrilla(int IdBarrio)
        {
            bool resultado = false;
            for (int i = 0; i < gdrBarrios.Rows.Count; i++)
            {
                if (gdrBarrios.Rows[i].Cells["IdBarrio"].Value.Equals(IdBarrio))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private void CargarCampos(Barrio b)
        {
            txtIdBarrio.Text = b.IdBarrio.ToString();
            txtNombre.Text = b.NombreBarrio.ToString();
            cmbIdLocalidad.SelectedValue = b.IdLocalidadBarrio;
        }

        private Barrio ObtenerDatosBarrio()
        {
            Barrio b = new Barrio();
            b.IdBarrio = int.Parse(txtIdBarrio.Text.Trim());
            b.NombreBarrio = txtNombre.Text.Trim();
            b.IdLocalidadBarrio = (int)cmbIdLocalidad.SelectedValue;
            if (txtIdBarrio.Text.Equals(""))
            {
                b.IdBarrio = 0;
            }
            else
            {
                b.IdBarrio = int.Parse(txtIdBarrio.Text);
            }

            return b;
        }

        private Barrio ObtenerBarrio(int IdBarrio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Barrio b = new Barrio();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consilta = "SELECT * FROM Barrio WHERE Id_Barrio LIKE @idBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idBarrio", IdBarrio);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consilta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    b.IdBarrio = int.Parse(dr["Id_Barrio"].ToString());
                    b.NombreBarrio = dr["nombre"].ToString();
                    b.IdLocalidadBarrio = int.Parse(dr["Id_Localidad"].ToString());
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

            return b;
        }

        private bool CamposCompletos()
        {
            bool resultado = false;
            if (txtIdBarrio.Text.Equals("") || txtNombre.Text.Equals("") || cmbIdLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                resultado = true;
            }

            return resultado;
        }

        private bool AgregarBarrioABD(Barrio b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Barrio (Id_Barrio, nombre, Id_Localidad) VALUES(@idBarrio, @nombre, @idLocalidad)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idBarrio", b.IdBarrio);
                cmd.Parameters.AddWithValue("@nombre", b.NombreBarrio);
                cmd.Parameters.AddWithValue("@idLocalidad", b.IdLocalidadBarrio);
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

        private void btnGuardarBarrio_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                Barrio b = ObtenerDatosBarrio();
                bool existe = ExisteEnGrilla(b.IdBarrio);

                if (!existe)
                {
                    bool resultado = AgregarBarrioABD(b);
                    if (resultado)
                    {
                        MessageBox.Show("Nuevo barrio agregado con éxito");
                        LimpiarCampos();
                        CargarComboLocalidad();
                        CargarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("Error! El barrio ingresado ya existe");
                    LimpiarCampos();
                    txtIdBarrio.Focus();
                }

            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtIdBarrio.Enabled = true;
        }

        private void gdrBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarBarrio.Enabled = true;
            btnBorrarBarrio.Enabled = true;
            txtIdBarrio.Enabled = false;

            DataGridViewRow filaSeleccionada = gdrBarrios.Rows[indice];
            int idBarrio = int.Parse(filaSeleccionada.Cells["IdBarrio"].Value.ToString());

            try
            {
                Barrio b = ObtenerBarrio(idBarrio);
                LimpiarCampos();
                CargarCampos(b);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los datos del barrio seleccionado");

            }
        }

        private bool ActualizarBarrio(Barrio bar)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            txtIdBarrio.Enabled = true;
            txtIdBarrio.Focus();
            btnGuardarBarrio.Enabled = true;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Barrio SET Nombre = @nombre, Id_Localidad = @idLocalidad WHERE Id_Barrio LIKE @idBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idBarrio", bar.IdBarrio);
                cmd.Parameters.AddWithValue("@nombre", bar.NombreBarrio);
                cmd.Parameters.AddWithValue("@idLocalidad", bar.IdLocalidadBarrio);
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

        private void btnActualizarBarrio_Click(object sender, EventArgs e)
        {
            Barrio b = ObtenerDatosBarrio();
            bool resultado = ActualizarBarrio(b);
            if (resultado)
            {
                MessageBox.Show("Barrio modificado con éxito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboLocalidad();
            }
            else
            {
                MessageBox.Show("Error al actualizar el barrio");
            }
        }

        private void EliminarBarrio(string idBarrio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Barrio WHERE Id_Barrio LIKE @idBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idBarrio", idBarrio);
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

        private void btnBorrarBarrio_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                string idBarrio = txtIdBarrio.Text;
                EliminarBarrio(idBarrio);
                MessageBox.Show("Barrio eliminado con éxito");
                LimpiarCampos();
                CargarGrilla();
                btnGuardarBarrio.Enabled = true;
                btnBorrarBarrio.Enabled = false;
                btnActualizarBarrio.Enabled = false;
                txtIdBarrio.Enabled = true;
                txtIdBarrio.Focus();
            }
        }
    }
}
