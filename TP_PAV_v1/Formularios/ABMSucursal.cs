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
    public partial class ABMSucursal : Form
    {
        public ABMSucursal()
        {
            InitializeComponent();
        }

        private void ABMSucursal_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarSucursal.Enabled = false;
            btnBorrarSucursal.Enabled = false;
            CargarComboProvincia();
            CargarGrilla();
        }

        private void CargarComboProvincia()
        {
            try
            {
                cmbIdProvincia.DataSource = AD_Sucursales.ObtenerComboProvincia();
                cmbIdProvincia.DisplayMember = "nombre";
                cmbIdProvincia.ValueMember = "Id_Prov";
                cmbIdProvincia.SelectedIndex = -1;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener provincias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void LimpiarCampos()
        {
            txtNroSucursal.Text = "";
            cmbIdProvincia.SelectedIndex = -1;
            txtNroSucursal.Focus();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNroSucursal.Enabled = true;
        }

        private Sucursal ObtenerDatosSucursal()
        {
            Sucursal s = new Sucursal();
            s.NroSucursal = int.Parse(txtNroSucursal.Text.Trim());
            s.IdProvinciaSucursal = (int)cmbIdProvincia.SelectedValue;
            if (txtNroSucursal.Text.Equals(""))
            {
                s.NroSucursal = 0;
            }
            else
            {
                s.NroSucursal = int.Parse(txtNroSucursal.Text);
            }

            return s;
        }

        private bool CamposCompletos()
        {
            bool resultado = false;
            if (txtNroSucursal.Text.Equals("") || cmbIdProvincia.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                resultado = true;
            }

            return resultado;
        }

       

        private void btnGuardarSucursal_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                Sucursal s = ObtenerDatosSucursal();
                bool existe = ExisteEnGrilla(s.NroSucursal, s.IdProvinciaSucursal);

                if (!existe)
                {

                    bool resultado = AD_Sucursales.AgregarSucursalABD(s);
                    if (resultado)
                    {
                        MessageBox.Show("Nueva sucursal agregada con éxito");
                        LimpiarCampos();
                        CargarComboProvincia();
                        CargarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("Error! La sucursal ya existe");
                    LimpiarCampos();
                    txtNroSucursal.Focus();
                }
            }

        }

        private void CargarGrilla()
        {
            try
            {
                gdrSucursales.DataSource = AD_Sucursales.ObtenerListadoSucursales(); ;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener sucursales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CargarCampos(Sucursal s)
        {
            txtNroSucursal.Text = s.NroSucursal.ToString();
            cmbIdProvincia.SelectedValue = s.IdProvinciaSucursal;
        }

        

        private bool ExisteEnGrilla(int NroSucursal, int IdProvincia)
        {
            bool resultado = false;
            for (int i = 0; i < gdrSucursales.Rows.Count; i++)
            {
                if (gdrSucursales.Rows[i].Cells["NroSucursal"].Value.Equals(NroSucursal) && (gdrSucursales.Rows[i].Cells["idProv"].Value.Equals(IdProvincia)))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }

        private void gdrSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarSucursal.Enabled = true;
            btnBorrarSucursal.Enabled = true;
            txtNroSucursal.Enabled = false;

            DataGridViewRow filaSeleccionada = gdrSucursales.Rows[indice];
            int nroSucursal = int.Parse(filaSeleccionada.Cells["NroSucursal"].Value.ToString());

            try
            {
                Sucursal s = AD_Sucursales.ObtenerSucursal(nroSucursal);
                LimpiarCampos();
                CargarCampos(s);

            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los datos de la sucursal seleccionada ");
            }

        }

        

        private void btnActualizarSucursal_Click(object sender, EventArgs e)
        {
            Sucursal s = ObtenerDatosSucursal();
            // ver esto--- estaba abajo del la declaracion de resultado en la funcion SQL
            txtNroSucursal.Enabled = true;
            txtNroSucursal.Focus();
            btnGuardarSucursal.Enabled = true;
            bool resultado = AD_Sucursales.ActualizarSucursal(s);
            if (resultado)
            {
                MessageBox.Show("Sucursal modificada con éxito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboProvincia();
               
            }
            else
            {
                MessageBox.Show("Error al actualizar la sucursal");
            }
        }



        private void btnBorrarSucursal_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                string nroSucursal = txtNroSucursal.Text;
                AD_Sucursales.EliminarSucursal(nroSucursal);
                MessageBox.Show("Sucursal eliminada con éxito");
                LimpiarCampos();
                CargarGrilla();
                btnGuardarSucursal.Enabled = true;
                btnBorrarSucursal.Enabled = false;
                btnActualizarSucursal.Enabled = false;
                txtNroSucursal.Enabled = true;
                txtNroSucursal.Focus();


            }
        }

      

        private void cmbIdProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
