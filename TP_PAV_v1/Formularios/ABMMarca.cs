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
    public partial class ABMMarca : Form
    {
        public ABMMarca()
        {
            InitializeComponent();
        }

        private void ABMMarca_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizar.Enabled = false;
            CargarGrilla();
            txtIdMarca.Visible = false;
            lblIdMarca.Visible = false;
            btnBorrar.Enabled = false;

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();


        }

        private void LimpiarCampos()
        {
            txtNombreMarca.Text = "";

        }

        private Marca ObtenerDatosMarca()
        {
            if (!(txtNombreMarca.Text.Equals("")))
            {
                var mar = new Marca();

                if (txtIdMarca.Text != "")
                {
                    mar.IdMarca = int.Parse(txtIdMarca.Text);
                }

                mar.NombreMarca = txtNombreMarca.Text.Trim();


                return mar;

            }

            Marca error = new Marca();
            error.IdMarca = int.Parse("-1");
            return error;


        }
        private void CargarGrilla()
        {
            try
            {
                gdrMarca.DataSource = AD_Marcas.ObtenerMarcas();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener marcas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Marca mar = ObtenerDatosMarca();
            if (mar.IdMarca != int.Parse("-1"))
            {
                bool yaexiste = ExisteEnGrilla(mar.NombreMarca);
                if (!yaexiste)
                {
                    bool result = AD_Marcas.AgregarMarca(mar);
                    if (result)
                    {
                        MessageBox.Show("Marca agregada con exito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El nombre ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ExisteEnGrilla(string nombreMarca)
        {
            bool resultado = false;
            for (int i = 0; i < gdrMarca.Rows.Count; i++)
            {
                if (gdrMarca.Rows[i].Cells["nombre"].Value.Equals(nombreMarca))
                {
                    resultado = true;
                    break;

                }
            }

            return resultado;
        }

       

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult QuestionResult = MessageBox.Show("¿Está seguro que desea actualizar la marca?", "Actualizar fila grilla", botones, MessageBoxIcon.Warning);

            if (QuestionResult == DialogResult.Yes)
            {
                Marca mar = ObtenerDatosMarca();
                if (mar.IdMarca != int.Parse("-1"))
                {
                    // para que el usuario no actualice a un nombre de marca que ya exista
                    bool yaexiste = ExisteEnGrilla(mar.NombreMarca);
                    //false existe
                    if (!yaexiste)
                    {
                        bool result = AD_Marcas.ActualizarMarca(mar);
                        if (result)
                        {
                            MessageBox.Show("Marca actualizada con exito", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarCampos();
                            CargarGrilla();
                            btnGuardar.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nombre ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    btnGuardar.Enabled = true;
                    MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void gdrMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            btnGuardar.Enabled = false;
            if (indice != -1)
            {
                DataGridViewRow filaseleccionada = gdrMarca.Rows[indice];
                string idMarca = filaseleccionada.Cells["IdMarca"].Value.ToString();
                Marca mar = AD_Marcas.ObtenerMarca(idMarca);
                LimpiarCampos();
                CargarCampos(mar);


            }
        }

        private void CargarCampos(Marca mar)
        {
            txtIdMarca.Text = mar.IdMarca.ToString(); ;
            txtNombreMarca.Text = mar.NombreMarca;
        }

       

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult QuestionResult = MessageBox.Show("¿Está seguro que desea eliminar la marca?", "Eliminar fila grilla", botones, MessageBoxIcon.Warning);

            if (QuestionResult == DialogResult.Yes)
            {
                Marca mar = ObtenerDatosMarca();
                bool referenciado = AD_Marcas.EstaReferenciada(mar);
                if (!referenciado)
                {
                    bool result = AD_Marcas.BorrarMarca(mar);

                    if (result)
                    {
                        MessageBox.Show("Marca borrada con exito", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarGrilla();
                        btnGuardar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al borrar la marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede borrar una marca que esta siendo utilizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

       

        private void ABMMarca_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = true;
            CargarGrilla();

        }
    }
}
