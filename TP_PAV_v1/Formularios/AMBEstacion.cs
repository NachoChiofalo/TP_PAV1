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
using TP_PAV_v1.AccesoADatos;
using TP_PAV_v1.Entidades;

namespace TP_PAV_v1.Formularios
{
    public partial class ABMEstacion : Form
    {
        public ABMEstacion()
        {
            InitializeComponent();
        }

        private void ABMEstacion_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

            btnActualizarEstacion.Enabled = false;
            btnGuardarEstacion.Enabled = true;
            btnBorrarEstacion.Enabled = false;
            CargarComboSucursales();
            CargarComboProvincia();
            CargarGrilla();
        }

        private Estacion ObtenerDatosEstacion()
        {
            Estacion es = new Estacion();
 
            es.CUITEstacion = txtCUIT.Text.Trim();
            
            es.NombreEstaciones = txtNombreEstacion.Text.Trim();
            es.IdSucursalEstacion = (int)cmbNroSucursal.SelectedValue;
            es.CalleEstacion = txtCalleEstacion.Text.Trim();
            es.AlturaEstacion = int.Parse(txtAlturaEstacion.Text.Trim());
            es.IdProvinciaEstacion = (int)cmbIdProvinciaEstacion.SelectedValue;
            es.LegajoGerenteEstacion = txtLegajoGerenteEstacion.Text.Trim();
            es.PlantaEstacion = txtPlantaEstacion.Text.Trim();
                



            return es;
        }

        private void btnGuardarEstacion_Click(object sender, EventArgs e)
        {


            if (txtCUIT.Text.Equals("") || txtNombreEstacion.Text.Equals("") || cmbNroSucursal.SelectedIndex == -1 || cmbIdProvinciaEstacion.SelectedIndex == -1 || txtLegajoGerenteEstacion.Text.Equals("") || txtCalleEstacion.Text.Equals("") || txtAlturaEstacion.Text.Equals("") || txtPlantaEstacion.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los datos correctamenteee");

            }
            else
            {
                if (ExisteEnGrilla(txtCUIT.Text) == false)
                {
                    Estacion es = ObtenerDatosEstacion();
                    bool resultado = AD_Estaciones.AgregarEstacionABD(es);
                    if (resultado)
                    {
                        MessageBox.Show("Estacion agregada con exito");
                        LimpiarCampos();
                        CargarComboSucursales();
                        CargarComboProvincia();
                        CargarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe en grilla ese cuit");
                }
                
            }



        }

        
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreEstacion.Text = "";
            txtCUIT.Text = "";
            cmbNroSucursal.SelectedIndex = -1;
            txtCalleEstacion.Text = "";
            txtAlturaEstacion.Text = "";
            cmbIdProvinciaEstacion.SelectedIndex = -1;
            txtLegajoGerenteEstacion.Text = "";
            txtPlantaEstacion.Text = "";
        }

        private bool ExisteEnGrilla(string criterioABuscar)
        {
            bool resultado = false;

            for (int i = 0; i < gdrEstacion.Rows.Count; i++)
            {
                if (gdrEstacion.Rows[i].Cells["CUIT"].Value.Equals(criterioABuscar))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private void CargarGrilla()
        {
            try
            {
                gdrEstacion.DataSource = AD_Estaciones.ObtenerListadoEstaciones();

            }
            catch (Exception)
            {

                throw;
            }
          

        }

        private void CargarComboSucursales()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "Select * from Sucursales";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbNroSucursal.DataSource = tabla;
                cmbNroSucursal.DisplayMember = "Nro_Sucursal";
                cmbNroSucursal.ValueMember = "Nro_Sucursal";
                cmbNroSucursal.SelectedIndex = -1;

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

        private void CargarComboProvincia()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "Select * from Provincia";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbIdProvinciaEstacion.DataSource = tabla;
                cmbIdProvinciaEstacion.DisplayMember = "Id_Prov";
                cmbIdProvinciaEstacion.ValueMember = "Id_Prov";
                cmbIdProvinciaEstacion.SelectedIndex = -1;

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
        //UPDATE:
        private void gdrEstacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarEstacion.Enabled = true;
            btnBorrarEstacion.Enabled = true;
            DataGridViewRow filaSeleccionada = gdrEstacion.Rows[indice];
            string cuit = filaSeleccionada.Cells["CUIT"].Value.ToString();
            Estacion es = AD_Estaciones.ObtenerEstacion(cuit);
            LimpiarCampos();
            CargarCampos(es);
        }

        private void CargarCampos(Estacion es)
        {
            txtCUIT.Text = es.CUITEstacion;
            txtNombreEstacion.Text = es.NombreEstaciones;
            cmbNroSucursal.SelectedValue = es.IdSucursalEstacion;
            txtCalleEstacion.Text = es.CalleEstacion;
            txtAlturaEstacion.Text = es.AlturaEstacion.ToString();
            cmbIdProvinciaEstacion.SelectedValue = es.IdProvinciaEstacion;
            txtLegajoGerenteEstacion.Text = es.LegajoGerenteEstacion;
            txtPlantaEstacion.Text = es.PlantaEstacion;

        }

        

        private void btnActualizarEstacion_Click(object sender, EventArgs e)
        {
            Estacion es = ObtenerDatosEstacion();
            bool resultado = AD_Estaciones.ActualizarEstacionBD(es);
            if (resultado)
            {
                MessageBox.Show("Estacion actualizada con exito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboProvincia();
                CargarComboSucursales();
                btnActualizarEstacion.Enabled = false;
                btnBorrarEstacion.Enabled = false;
                btnGuardarEstacion.Enabled = true;

            }
            else
            {
                MessageBox.Show("Error al actualizar estacion");
            }
        }

       

        //Deletes:
       
        private void btnBorrarEstacion_Click(object sender, EventArgs e)
        {
            Estacion es = ObtenerDatosEstacion();
            bool resultado = AD_Estaciones.EliminarEstacion(es);
            if (resultado)
            {

                MessageBox.Show("Empleado eliminado con exito");
                CargarGrilla();
                LimpiarCampos();
                CargarComboSucursales();
                CargarComboProvincia();
                btnActualizarEstacion.Enabled = false;
                btnBorrarEstacion.Enabled = false;
                btnGuardarEstacion.Enabled = true;

            }
            else
            {
                MessageBox.Show("Error al intentar eliminar empleado");

            }
        }

        
    }
    
}
