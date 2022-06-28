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
    public partial class ABMProvincia : Form
    {
        public ABMProvincia()
        {
            InitializeComponent();
        }

        private void ABMProvincia_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtIdProvincia.Text = "";
            txtCodigoPostal.Text = "";
            txtNombreProvincia.Text = "";
            txtIdProvincia.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtIdProvincia.Enabled = true;
        }

        private void CargarGrilla()
        {
            try
            {
                grillaProvincia.DataSource = AD_Provincias.ObtenerListadoProvincias();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener las provincias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private Provincias ObtenerDatosProvioncia()
        {
            Provincias p = new Provincias();
            p.IdDeLaProvincia = int.Parse(txtIdProvincia.Text);
            p.NombreDeLaProvincia = txtNombreProvincia.Text;
            p.CodigoPostalDeLaProvincia = txtCodigoPostal.Text;

            if (txtIdProvincia.Text.Equals(""))
            {
                p.IdDeLaProvincia = 0;
            }
            else
            {
                p.IdDeLaProvincia = int.Parse(txtIdProvincia.Text);
            }
            return p;
        }

        private bool CamposCompletos()
        {
            bool resultado = false;
            if (txtIdProvincia.Text.Equals("") || txtNombreProvincia.Text.Equals("") || txtCodigoPostal.Text.Equals(""))
            {
                MessageBox.Show("Complete todos los campos!!");

            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                Provincias p = ObtenerDatosProvioncia();
                bool existe = ExisteEnGrilla(p.IdDeLaProvincia);
                if (!existe)
                {
                    bool resultado = AD_Provincias.AgregarProvinciaABD(p);
                    if (resultado)
                    {
                        MessageBox.Show("Nueva Provincia agregada con exito!");
                        LimpiarCampos();
                        CargarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("Error! La provincia ya existe");
                    LimpiarCampos();
                    txtIdProvincia.Focus();
                }

            }
        }

        private bool ExisteEnGrilla(int idProvincia)
        {
            bool resultado = false;
            for (int i = 0; i < grillaProvincia.Rows.Count; i++)
            {
                if (grillaProvincia.Rows[i].Cells["idProvincia"].Value.Equals(idProvincia))
                {
                    resultado = true;
                    break;
                }

            }
            return resultado;
        }


        

        private void grillaProvincia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            txtIdProvincia.Enabled = false;
            DataGridViewRow filaSeleccionada = grillaProvincia.Rows[indice];
            int idProv = int.Parse(filaSeleccionada.Cells["idProvincia"].Value.ToString());
            try
            {
                Provincias p = AD_Provincias.ObtenerProvincia(idProv);
                LimpiarCampos();
                CargarCampos(p);
                // estaba en actualizar provincia abajo del bool resultado --- verificar 
                txtIdProvincia.Enabled = true;
                txtIdProvincia.Focus();
                btnGuardar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los datos de la provincia!");
            }
        }

        private void CargarCampos(Provincias p)
        {
            txtIdProvincia.Text = p.IdDeLaProvincia.ToString();
            txtNombreProvincia.Text = p.NombreDeLaProvincia;
            txtCodigoPostal.Text = p.CodigoPostalDeLaProvincia;
        }

       

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Provincias p = ObtenerDatosProvioncia();
            bool resultado = AD_Provincias.ActualizarProvincia(p);
            if (resultado)
            {
                MessageBox.Show("Provincia modificada con exito!");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al actualizar Provincia!");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                string idProvincia = txtIdProvincia.Text;
                AD_Provincias.EliminarProvincia(idProvincia);
                MessageBox.Show("La provincia fue eliminada con exito!");
                LimpiarCampos();
                CargarGrilla();
                btnGuardar.Enabled = true;
                btnBorrar.Enabled = false;
                btnActualizar.Enabled = false;
                txtIdProvincia.Enabled = true;
                txtIdProvincia.Focus();
            }
        }
    }
}
