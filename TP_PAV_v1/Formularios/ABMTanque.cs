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
    public partial class ABMTanque : Form
    {
        public ABMTanque()
        {
            InitializeComponent();
        }

        private void ABMTanque_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

            btnActualizarTanque.Enabled = false;
            btnGuardadTanque.Enabled = true;
            btnBorrarTanque.Enabled = false;
            CargarComboTiposCombustible();
            CargarGrilla();
        }


        private void LimpiarCampos()
        {
            txtNroTanque.Text = "";
            txtCUITTanque.Text = "";
            txtVolMax.Text = "";
            txtVolMin.Text = "";
            cmbCodTipoCombustible.SelectedValue = -1;
        }

        private void btnGuardadTanque_Click(object sender, EventArgs e)
        {

            if (txtCUITTanque.Text.Equals("") || txtNroTanque.Text.Equals("") || txtVolMax.Text.Equals("") || txtVolMin.Text.Equals("") || cmbCodTipoCombustible.SelectedIndex == -1)
            {
                MessageBox.Show("Cargue correctamente los tanques");
            }
            else
            {
                if (ExisteEnGrilla(txtNroTanque.Text) == false)
                {
                    Tanques t = ObtenerDatosTanques();
                    bool resultado = ValidarTamaños();
                    if (resultado)
                    {
                        bool result = AD_Tanque.AgregarTanquesABD(t);
                        if (result)
                        {
                            MessageBox.Show("Tanque agregado con exito");
                            LimpiarCampos();
                            CargarComboTiposCombustible();
                            CargarGrilla();
                        }
                    }
                  
                }
                else
                {
                    MessageBox.Show("Ya existe en grilla este tanque");
                }
                
            }
            
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }



        private void CargarGrilla()
        {
            try
            {

                gdrTanques.DataSource = AD_Tanque.ObtenerListadoTanques();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener tanques", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private bool ExisteEnGrilla(string criterioABuscar)
        {
            bool resultado = false;

            for (int i = 0; i < gdrTanques.Rows.Count; i++)
            {
                if (gdrTanques.Rows[i].Cells["NroTanque"].Value.Equals(criterioABuscar))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private Tanques ObtenerDatosTanques()
        {
            Tanques t = new Tanques();
            t.CUITTanque = txtCUITTanque.Text.Trim();
            t.NroTanques = int.Parse(txtNroTanque.Text.Trim());
            t.VolMaxTanque = int.Parse(txtVolMax.Text.Trim());
            t.VolMinTanque = int.Parse(txtVolMin.Text.Trim());
            t.CodTipoCombustibleTanque = (int)cmbCodTipoCombustible.SelectedValue;
            
            return t;
        }

        private void gdrTanques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarTanque.Enabled = true;
            btnBorrarTanque.Enabled = true;
            DataGridViewRow filaSeleccionada = gdrTanques.Rows[indice];
            string cuit = filaSeleccionada.Cells["CUIT"].Value.ToString();
            int nroTanque = int.Parse(filaSeleccionada.Cells["NroTanque"].Value.ToString());
            Tanques t = AD_Tanque.ObtenerTanques(cuit, nroTanque);
            LimpiarCampos();
            CargarCampos(t);
        }

        private void CargarComboTiposCombustible()
        {
            try
            {
                cmbCodTipoCombustible.DataSource = AD_TipoCombustible.ObtenerTiposCombustibles();
                cmbCodTipoCombustible.DisplayMember = "Cod_Tipo_Combustible";
                cmbCodTipoCombustible.ValueMember = "Cod_Tipo_Combustible";
                cmbCodTipoCombustible.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los tipos de combustibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCampos(Tanques t)
        {
            txtCUITTanque.Text = t.CUITTanque;
            txtNroTanque.Text = t.NroTanques.ToString();
            txtVolMax.Text = t.VolMaxTanque.ToString();
            txtVolMin.Text = t.VolMinTanque.ToString();
            cmbCodTipoCombustible.Text = t.CodTipoCombustibleTanque.ToString();
        }

        private void btnActualizarTanque_Click(object sender, EventArgs e)
        {
            Tanques t = ObtenerDatosTanques();
            bool resultado = AD_Tanque.ActualizarTanqueBD(t);
            if (resultado)
            {
                MessageBox.Show("Estacion actualizada con exito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboTiposCombustible();
                btnActualizarTanque.Enabled = false;
                btnBorrarTanque.Enabled = false;
                btnGuardadTanque.Enabled = true;

            }

        }

        private void btnBorrarTanque_Click(object sender, EventArgs e)
        {
            Tanques t = ObtenerDatosTanques();
            bool resultado = AD_Tanque.EliminarTanques(t);
            if (resultado)
            {

                MessageBox.Show("Tanque eliminado con exito");
                CargarGrilla();
                LimpiarCampos();
                CargarComboTiposCombustible();
                btnActualizarTanque.Enabled = false;
                btnBorrarTanque.Enabled = false;
                btnGuardadTanque.Enabled = true;

            }

        }

        private bool ValidarTamaños()
        {
            bool resultado = true;
            string CUIT = txtCUITTanque.Text.ToString();

            try
            {
                if (CUIT.Length < 7)
                {
                    MessageBox.Show("Error en el tamaño del cuit, ingresar nuevamente");
                    txtCUITTanque.Focus();
                    resultado = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ingresar nuevamente el cuit");
            }

            return resultado;
        }
    }
}
