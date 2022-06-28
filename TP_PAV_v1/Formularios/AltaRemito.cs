using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_v1.AccesoADatos;

namespace TP_PAV_v1.Formularios
{
    public partial class AltaRemito : Form
    {
        public AltaRemito()
        {
            InitializeComponent();
        }

        private void AltaRemito_Load(object sender, EventArgs e)
        {
            CargarFecha();
            ObtenerUltimoNroRemito();
            txtTotal.Text = "0";
        }

        private void CargarFecha()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void ObtenerUltimoNroRemito()
        {
            int NroRemito = AD_Remitos.ObtenerUltimoIdentRemitos();
            txtNroRemito.Text = (NroRemito).ToString();

        }

        private void btnBuscarEstacion_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Estaciones.ObtenerEstacionXCuit(int.Parse(txtCuit.Text));

                if (tablaResultado.Rows.Count > 0)
                {
                    txtNombreEstacion.Text = tablaResultado.Rows[0][1].ToString();
                    txtIdSucursal.Text = tablaResultado.Rows[0][2].ToString();
                    txtProvincia.Text = tablaResultado.Rows[0][3].ToString();
                    txtIdProvincia.Text = tablaResultado.Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("El número de CUIT no pertenece a ninguna estación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCuit.Focus();
                    txtNombreEstacion.Text = "";
                    txtIdSucursal.Text = "";
                    txtProvincia.Text = "";
                    txtIdProvincia.Text = "";
                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscarCamion_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Camiones.ObtenerCamionXPatente(txtPatente.Text);

                if (tablaResultado.Rows.Count > 0)
                {
                    txtModelo.Text = tablaResultado.Rows[0][1].ToString();
                    txtMarca.Text = tablaResultado.Rows[0][2].ToString();
                }
                else
                {
                    MessageBox.Show("El número de patente no pertenece a ningun camión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPatente.Focus();
                    txtModelo.Text = "";
                    txtMarca.Text = "";
                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Empleados.ObtenerEmpleadoXLegajo(txtLegajo.Text);

                if (tablaResultado.Rows.Count > 0)
                {
                    txtNombreEmpleado.Text = tablaResultado.Rows[0][1].ToString();
                    txtApellidoEmpleado.Text = tablaResultado.Rows[0][2].ToString();
                }
                else
                {
                    MessageBox.Show("El legajo no pertenece a ningun empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLegajo.Focus();
                    txtNombreEmpleado.Text = "";
                    txtApellidoEmpleado.Text = "";
                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscarTipoCombustible_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodTipoCombu.Text.Trim().Equals(""))
                {
                    MessageBox.Show("El codigo no pertenece a ningun tipo de combustible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DataTable tablaResultado = AD_TipoCombustible.ObtenerCombustibleXCodigo(int.Parse(txtCodTipoCombu.Text.Trim()));

                    if (tablaResultado.Rows.Count > 0)
                    {
                        txtNombreTipoCombu.Text = tablaResultado.Rows[0][1].ToString();
                    }
                    else
                    {
                        MessageBox.Show("El codigo no pertenece a ningun tipo de combustible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodTipoCombu.Focus();
                        txtNombreTipoCombu.Text = "";
                    }


                }



            }
            catch (Exception)
            {

                throw;
            }
        }
        //int.Parse(txtPrecioXLitro.Text.Trim()).... int.Parse(txtCantLitros.Text.Trim())

        private void btnCalcularSubtotal_Click(object sender, EventArgs e)
        {
            if (!txtPrecioXLitro.Text.Trim().Equals("") && !txtCantLitros.Text.Trim().Equals(""))
            {
                txtSubTotal.Text = (int.Parse(txtPrecioXLitro.Text.Replace(" ", String.Empty)) * int.Parse(txtCantLitros.Text.Replace(" ", String.Empty))).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if(ValidadCamposCombustible())
            {
                grillaDetalle.Rows.Add(txtCodTipoCombu.Text, txtCantLitros.Text, txtSubTotal.Text);

                txtTotal.Text = (int.Parse(txtTotal.Text) + int.Parse(txtSubTotal.Text)).ToString();
                txtSubTotal.Text = "";
                LimpiarCamposDetalle();
            }
            else
            {
                MessageBox.Show("Algunos campos estan vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //para ayudar a validar que no ingrese el mismo codigo, forzamos al usuario a buscar de nuevo si cambia algo
        private void txtCodTipoCombu_TextChanged(object sender, EventArgs e)
        {
            txtNombreTipoCombu.Text = "";
        }

        private bool ValidadCamposCombustible()
        {
            bool resultado = false;

            if (!txtSubTotal.Text.Equals("") && !txtCodTipoCombu.Text.Equals("") && !txtNombreTipoCombu.Text.Equals("") && !txtPrecioXLitro.Text.Trim().Equals("") && !txtCantLitros.Text.Trim().Equals(""))
            {
                resultado = true;
            }


            return resultado;

        }


        private void btnGuardarRemito_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult QuestionResult = MessageBox.Show("¿Está seguro que quiere dar de alta el remito?", "Alta remito", botones, MessageBoxIcon.Warning);

            if (QuestionResult == DialogResult.Yes)
            {
                List<int> ListaDetalles = new List<int>();
                for (int i = 0; i < grillaDetalle.Rows.Count; i++)
                {
                    ListaDetalles.Add(int.Parse(grillaDetalle.Rows[i].Cells[0].Value.ToString()));
                }

                List<int> ListaLitros = new List<int>();
                for (int i = 0; i < grillaDetalle.Rows.Count; i++)
                {
                    ListaLitros.Add(int.Parse(grillaDetalle.Rows[i].Cells[1].Value.ToString()));


                }
                List<int> SubTotal = new List<int>();
                for (int i = 0; i < grillaDetalle.Rows.Count; i++)
                {
                    SubTotal.Add(int.Parse(grillaDetalle.Rows[i].Cells[2].Value.ToString()));
                }

               

                bool resultado = AD_Remitos.AltaNuevoRemito(int.Parse(txtNroRemito.Text.Trim()), Convert.ToDateTime(txtFecha.Text.Trim()), int.Parse(txtCuit.Text.Trim()), txtPatente.Text, txtLegajo.Text, int.Parse(txtIdSucursal.Text), int.Parse(txtIdProvincia.Text), int.Parse(txtTotal.Text), ListaLitros, SubTotal, ListaDetalles);
                // 207412

                if (resultado)
                {
                    MessageBox.Show("Remito dado de alta con exito!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtenerUltimoNroRemito();
                    LimpiarCampos();
                    LimpiarCamposDetalle();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al dar de alta nuevo remito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            
            
        }

        private void LimpiarCampos()
        {
            txtCuit.Text = "";
            txtPatente.Text = "";
            txtCuit.Text = "";
            txtIdSucursal.Text= "";
            txtLegajo.Text =   "";
            txtNombreEstacion.Text = "";
            txtProvincia.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtNombreEmpleado.Text = "";
            txtApellidoEmpleado.Text = "";
            txtCantLitros.Text = "";
           
            
        }
        private void LimpiarCamposDetalle()
        {
            txtCodTipoCombu.Text = "";
            txtNombreTipoCombu.Text = "";
            txtPrecioXLitro.Text = "";
            txtCantLitros.Text = "";
            txtSubTotal.Text = "";
          
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            LimpiarCamposDetalle();     
        }
    }
}
