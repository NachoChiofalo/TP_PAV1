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
    public partial class ABMTurno : Form
    {
        public ABMTurno()
        {
            InitializeComponent();
        }

        private void ABMTurno_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
        }
        private void LimpiarCampos()
        {
            txtIdTurno.Text = "";
            txtDescripcion.Text = "";
            txtIdTurno.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtIdTurno.Enabled = true;
        }

        private void CargarGrilla()
        {
            try
            {
                grillaTurno.DataSource = AD_Turnos.ObtenerListadoTurnos();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener turnos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Turno ObtenerDatosTurno()
        {
            Turno t = new Turno();
            t.IdDelTurno = int.Parse(txtIdTurno.Text);
            t.DescripcionTurno = txtDescripcion.Text;


            if (txtIdTurno.Text.Equals(""))
            {
                t.IdDelTurno = 0;
            }
            else
            {
                t.IdDelTurno = int.Parse(txtIdTurno.Text);
            }
            return t;
        }

        private bool CamposCompletos()
        {
            bool resultado = false;
            if (txtIdTurno.Text.Equals("") || txtDescripcion.Text.Equals(""))
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
                Turno t = ObtenerDatosTurno();
                bool existe = ExisteEnGrilla(t.IdDelTurno);
                if (!existe)
                {
                    bool resultado = AD_Turnos.AgregarTurnoABD(t);
                    if (resultado)
                    {
                        MessageBox.Show("Nuevo Turno agregado con exito!");
                        LimpiarCampos();
                        CargarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("Error! El turno ya existe");
                    LimpiarCampos();
                    txtIdTurno.Focus();
                }

            }
        }

        private bool ExisteEnGrilla(int idTurno)
        {
            bool resultado = false;
            for (int i = 0; i < grillaTurno.Rows.Count; i++)
            {
                if (grillaTurno.Rows[i].Cells["idTurno"].Value.Equals(idTurno))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }


        private void grillaTurno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            txtIdTurno.Enabled = false;
            DataGridViewRow filaSeleccionada = grillaTurno.Rows[indice];
            int idTurno = int.Parse(filaSeleccionada.Cells["idTurno"].Value.ToString());
            try
            {
                Turno t = AD_Turnos.ObtenerTurno(idTurno);
                LimpiarCampos();
                CargarCampos(t);

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los datos del turno!");
            }
        }
        private void CargarCampos(Turno t)
        {
            txtIdTurno.Text = t.IdDelTurno.ToString();
            txtDescripcion.Text = t.DescripcionTurno;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Turno t = ObtenerDatosTurno();
            bool resultado = AD_Turnos.ActualizarTurno(t);
            if (resultado)
            {
                MessageBox.Show("Turno modificado con exito!");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al actualizar Turno!");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool completo = CamposCompletos();
            if (completo)
            {
                string idTurno = txtIdTurno.Text;
                AD_Turnos.EliminarTurno(idTurno);
                MessageBox.Show("El turno fue eliminado con exito!");
                LimpiarCampos();
                CargarGrilla();
                btnGuardar.Enabled = true;
                btnBorrar.Enabled = false;
                btnActualizar.Enabled = false;
                txtIdTurno.Enabled = true;
                txtIdTurno.Focus();
            }
        }
    }
}
