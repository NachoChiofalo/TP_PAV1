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
    public partial class ABMCamion : Form
    {
        public ABMCamion()
        {
            InitializeComponent();
        }

        private void ABMCamion_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarCombosMarca();
            CargarGrilla();
            btnActualizar.Enabled = false;

        }

        private void CargarGrilla()
        {
            try
            {
                gdrCamion.DataSource = AD_Camiones.ObtenerListadoCamiones();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener camiones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void CargarCombosMarca()
        {     
            try
            {
                cmbMarca.DataSource = AD_Camiones.ObtenerMarcas();
                cmbMarca.DisplayMember = "Nombre";
                cmbMarca.ValueMember = "Id_Marca";
                cmbMarca.SelectedIndex = -1;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener marcas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtModelo.Text = "";
            txtPatente.Text = "";
        }


        private Camion ObtenerDatosCamion()
        {
            if (!(txtPatente.Text.Equals("")) && !(txtModelo.Text.Equals("")) && !(cmbMarca.Text.Equals("")))
            {
                var ca = new Camion
                {
                    Patente = txtPatente.Text.Trim(),
                    Modelo = txtModelo.Text.Trim(),
                    Marca = (int)cmbMarca.SelectedValue,
                };
                return ca;
            }
            Camion error = new Camion();
            error.Patente = "-1";
            return error;
        }



        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Camion ca = ObtenerDatosCamion();
            if (ca.Patente != "-1")
            {
                bool yaexiste = ExisteEnGrilla(ca.Patente);
                if (!yaexiste)
                {
                    bool resultado = AD_Camiones.AgregarCamion(ca);
                    if (resultado)
                    {
                        MessageBox.Show("Camión agregado con exito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarCombosMarca();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar el camión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La patente ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteEnGrilla(string patente)
        {
            bool resultado = false;
            for (int i = 0; i < gdrCamion.Rows.Count; i++)
            {
                if (gdrCamion.Rows[i].Cells["patente"].Value.Equals(patente))
                {
                    resultado = true;
                    break;

                }
            }

            return resultado;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
            DialogResult QuestionResult = MessageBox.Show("¿Está seguro que desea actualizar el camión?", "Actualizar fila grilla", botones, MessageBoxIcon.Warning);

            if (QuestionResult == DialogResult.Yes)
            {
                Camion ca = ObtenerDatosCamion(); // fede no va la de jose

                if (ca.Patente != "-1")
                {
                    bool result = AD_Camiones.ActualizarCamion(ca);
                    if (result)
                    {
                        MessageBox.Show("Camión actualizado con exito", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarGrilla();
                        CargarCombosMarca();
                        btnGuardar.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el camión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    btnGuardar.Enabled = true;
                    MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

       

        private void gdrCamion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            btnGuardar.Enabled = false;
            txtPatente.Enabled = false;
            if (indice != -1)
            {
                DataGridViewRow filaseleccionada = gdrCamion.Rows[indice];
                string patente = filaseleccionada.Cells["patente"].Value.ToString();
                Camion ca = AD_Camiones.ObtenerCamion(patente);
                LimpiarCampos();
                CargarCampos(ca);


            }
        }

        private void CargarCampos(Camion ca)
        {
            txtPatente.Text = ca.Patente;
            txtModelo.Text = ca.Modelo;
            cmbMarca.SelectedValue = ca.Marca;
        }

       

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
            DialogResult QuestionResult = MessageBox.Show("¿Está seguro que desea eliminar el camión?", "Eliminar fila grilla", botones, MessageBoxIcon.Warning);

            if (QuestionResult == DialogResult.Yes)
            {
                Camion ca = ObtenerDatosCamion();

                bool resultado = AD_Camiones.BorrarCamion(ca);

                if (resultado)
                {
                    MessageBox.Show("Camión borrado con exito", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrilla();
                    btnGuardar.Enabled = true;
                    CargarCombosMarca();

                }
                else
                {
                    MessageBox.Show("Error al borrar el camión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ABMCamion_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = true;
            txtPatente.Enabled = true;
            CargarGrilla();
            CargarCombosMarca();
        }
    }
}

