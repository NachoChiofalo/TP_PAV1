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
    public partial class ABMTipoCombustible : Form
    {
        public ABMTipoCombustible()
        {
            InitializeComponent();
        }

        private void ABMTipoCombustible_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
           
            try
            {
                

                gdrTipoCombustible.DataSource = AD_TipoCombustible.ObtenerTiposCombustibles();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                TipoCombustible comb = ObtenerDatosTipoCombustible();

                bool existe = ExisteEnGrilla(comb.Cod_Tipo_Combustible, comb.nombre);
                if (!existe)
                {
                    bool resultado = AD_TipoCombustible.AgregarTipoCombustibleABD(comb);
                    if (resultado)
                    {
                        MessageBox.Show("Tipo de combustible agregado con exito");
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

        private TipoCombustible ObtenerDatosTipoCombustible()
        {
            TipoCombustible comb = new TipoCombustible();
            comb.nombre = txtNombre.Text;
            if (txtCodigo.Text.Equals(""))
            {
                comb.Cod_Tipo_Combustible = 0;
            }
            else
            {
                comb.Cod_Tipo_Combustible = int.Parse(txtCodigo.Text);

            }

            return comb;
        }

       

        private bool ExisteEnGrilla(int codigo, string nombre)
        {
            bool resultado = false;
            for (int i = 0; i < gdrTipoCombustible.Rows.Count; i++)
            {
                if (gdrTipoCombustible.Rows[i].Cells["Cod_Tipo_Combustible"].Value.Equals(codigo) || gdrTipoCombustible.Rows[i].Cells["nombre"].Value.Equals(nombre))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }


        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCodigo.Text = "";
        }



       

        private void CargarCampos(TipoCombustible t)
        {

            txtNombre.Text = t.nombre;
            txtCodigo.Text = t.Cod_Tipo_Combustible.ToString();
        }

        private void gdrTipoCombustible_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = gdrTipoCombustible.Rows[indice];
            string cod = filaseleccionada.Cells["Cod_Tipo_Combustible"].Value.ToString();
            TipoCombustible comb = AD_TipoCombustible.ObtenerTipoCombustible(cod);
            LimpiarCampos();
            CargarCampos(comb);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                TipoCombustible comb = ObtenerDatosTipoCombustible();
                bool referenciado = AD_TipoCombustible.EstaReferenciada(comb);
                if (!referenciado)
                {
                    MessageBox.Show("Tipo combustible borrado con exito");
                    string cod = txtCodigo.Text;
                    AD_TipoCombustible.EliminarTipoCombustible(cod);
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("No se puede borrar un tipo de combustible que esta siendo utilizado");
                }

            }
        }

       

        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                TipoCombustible comb = ObtenerDatosTipoCombustible();
                bool resultado = AD_TipoCombustible.ActualizarTipoCombustible(comb);

                if (resultado)
                {
                    MessageBox.Show("Tipo de combustible actualizado con exito");
                    LimpiarCampos();
                    CargarGrilla();

                }
            }
        }

        private bool CamposCompletos()
        {
            bool resultado = false;
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        
    }
}
