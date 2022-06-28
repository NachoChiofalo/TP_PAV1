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

namespace TP_PAV_v1
{
    public partial class ABMCombustible : Form
    {
        public ABMCombustible()
        {
            InitializeComponent();
        }

        private void ABMCombustible_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarComboTipoCombustible();
        }

        private void CargarGrilla()
        {
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            try
            {
                gdrCombustible.DataSource = AD_Combustibles.ObtenerCombustibles();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener combustibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboTipoCombustible()
        {
            try
            {
                cmbTipoCombustible.DataSource = AD_TipoCombustible.ObtenerTiposCombustibles();
                cmbTipoCombustible.DisplayMember = "nombre";
                cmbTipoCombustible.ValueMember = "Cod_Tipo_Combustible";
                cmbTipoCombustible.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los tipos de combustibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                Combustible combust = ObtenerDatosCombustible();

                bool existe = ExisteEnGrilla(combust.Cod_Combustible, combust.nombre);

                if (!existe)
                {
                    bool resultado = AD_Combustibles.AgregarCombustibleABD(combust);
                    if (resultado)
                    {
                        MessageBox.Show("Combustible agregado con exito");
                        CargarGrilla();
                        LimpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe en grilla");
                }

            }
        }

        private bool CamposCompletos()
        {
            bool resultado = false;
            if (txtNombreCombustible.Text.Equals("") || cmbTipoCombustible.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        private Combustible ObtenerDatosCombustible()
        {
            Combustible combust = new Combustible();
            combust.nombre = txtNombreCombustible.Text;
            combust.Cod_Tipo_Combustible = (int)(cmbTipoCombustible.SelectedValue);
            if (txtCodigoCombustible.Text.Equals(""))
            {
                combust.Cod_Combustible = 0;
            }
            else
            {
                combust.Cod_Combustible = int.Parse(txtCodigoCombustible.Text);

            }

            return combust;
        }

        private bool ExisteEnGrilla(int codigo, string nombre)
        {
            bool resultado = false;
            for (int i = 0; i < gdrCombustible.Rows.Count; i++)
            {
                if (gdrCombustible.Rows[i].Cells["Cod_Combustible"].Value.Equals(codigo) || gdrCombustible.Rows[i].Cells["nombre"].Value.Equals(nombre))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private void gdrCombustible_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = gdrCombustible.Rows[indice];
            string cod = filaseleccionada.Cells["Cod_Combustible"].Value.ToString();
            Combustible combust = AD_Combustibles.ObtenerCombustible(cod);
            LimpiarCampos();
            CargarCampos(combust);
        }

        private void CargarCampos(Combustible combust)
        {

            txtNombreCombustible.Text = combust.nombre;
            txtCodigoCombustible.Text = combust.Cod_Combustible.ToString();
            cmbTipoCombustible.SelectedValue = combust.Cod_Tipo_Combustible;

        }

        private void LimpiarCampos()
        {
            txtCodigoCombustible.Text = "";
            txtNombreCombustible.Text = "";
            cmbTipoCombustible.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                string cod = txtCodigoCombustible.Text;
                AD_Combustibles.EliminarCombustible(cod);
                LimpiarCampos();
                CargarGrilla();

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                Combustible combust = ObtenerDatosCombustible();
                bool resultado = AD_Combustibles.ActualizarCombustible(combust);

                if (resultado)
                {
                    MessageBox.Show("Combustible actualizado con exito");
                    LimpiarCampos();
                    CargarGrilla();

                }
            }
        }

    }

}
