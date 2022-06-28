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
    public partial class ABMTipoDocumento : Form
    {
        public ABMTipoDocumento()
        {
            InitializeComponent();
        }

        private void ABMTipoDocumento_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            btnActualizar.Enabled = false;
        }


        private void CargarGrilla()
        {

            try
            {
                dgrTipoDocumento.DataSource = AD_TipoDocumento.ObtenerListadoTiposDocumento();
            }


            catch (Exception)
            {

                throw;
            }
           
        }

        private void LimpiarCampos()
        {
            txtNombreTipoDoc.Text = "";

        }

        private TipoDocumento ObtenerDatos()
        {

            TipoDocumento td = new TipoDocumento();
            td.NombreTipoDocumento = txtNombreTipoDoc.Text.Trim();

            if (txtIdTipoDoc.Text != "")
            {
                td.IdTipoDocumento = int.Parse(txtIdTipoDoc.Text.Trim());
            }


            return td;

        }

        private bool validarNoVacios()
        {
            bool resultado = false;

            if (txtNombreTipoDoc.Text.Trim().Equals(""))
            {

                resultado = false;
                return resultado;
            }
            else
            {
                resultado = true;
            }

            return resultado;

        }


        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarNoVacios())
            {
                TipoDocumento td = ObtenerDatos();

                bool resultado = AD_TipoDocumento.AltaTipoDocumento(td);
                if (resultado)
                {
                    MessageBox.Show("Tipo de documento agregado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al intentar agregar tipo de decumento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Algun campo no fue completado de forma correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        

        private void dgrTipoDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                btnActualizar.Enabled = true;
                DataGridViewRow filaSeleccionada = dgrTipoDocumento.Rows[indice];
                string idTipoDoc = filaSeleccionada.Cells["idTipoDoc"].Value.ToString();

                TipoDocumento td = AD_TipoDocumento.ObtenerTipoDocumento(idTipoDoc);

                LimpiarCampos();
                CargarCampos(td);

            }

        }

        private void CargarCampos(TipoDocumento td)
        {
            txtNombreTipoDoc.Text = td.NombreTipoDocumento;
            txtIdTipoDoc.Text = td.IdTipoDocumento.ToString();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TipoDocumento td = ObtenerDatos();
            MessageBoxButtons botones = MessageBoxButtons.YesNo; DialogResult QuestionResult = MessageBox.Show("¿Está seguro que desea actualizar tipo de documento?", "Tipo de documento", botones, MessageBoxIcon.Warning);
            if (QuestionResult == DialogResult.Yes)
            {
                bool resultado = AD_TipoDocumento.ModificarTipoDocumento(td);
                if (resultado)
                {
                    CargarGrilla();
                    MessageBox.Show("Tipo de documento actualizado con exito", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    LimpiarCampos();



                }
                else
                {
                    MessageBox.Show("Error al intentar actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


       

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            TipoDocumento td = ObtenerDatos();

            MessageBoxButtons botones = MessageBoxButtons.YesNo; DialogResult QuestionResult = MessageBox.Show("¿Está seguro que desea eliminar tipo de documento?", "Tipo de documento", botones, MessageBoxIcon.Warning);
            if (QuestionResult == DialogResult.Yes)
            {
                bool resultado = AD_TipoDocumento.EliminarTipoDocumento(td);
                if (resultado)
                {

                    CargarGrilla();
                    MessageBox.Show("Tipo de documento borrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();



                }
                else
                {
                    MessageBox.Show("Error al intentar borrar tipo de documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
