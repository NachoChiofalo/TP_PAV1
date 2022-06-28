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
    public partial class ABMEmpleados : Form
    {
        public ABMEmpleados()
        {
            InitializeComponent();
        }

        private void ABMEmpleados_Load(object sender, EventArgs e)
        {
            CargarComboTiposDocumento();
            CargarComboBarrio();
            CargarGrilla();

            btnActualizar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtAltura.Text = "";
            txtCalle.Text = "";
            txtCuil.Text = "";
            txtDocumento.Text = "";
            txtFecha.Text = "";
            txtLegajo.Text = "";

        }

        private bool EsFecha(String fecha)
        {
            bool resultado = false;

            try
            {
                DateTime fecha1 = DateTime.Parse(fecha);
                string año = fecha1.Date.Year.ToString();
                if (año.Length == 4)
                {
                    resultado = true;
                }
                
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }
        private bool validarNoVacios()
        {
            bool resultado = false;

            if (txtNombre.Text.Trim().Equals("") || txtApellido.Text.Trim().Equals("") ||
                txtAltura.Text.Trim().Equals("") || txtCalle.Text.Trim().Equals("") ||
                txtCuil.Text.Trim().Equals("") || txtDocumento.Text.Trim().Equals("") ||
                txtFecha.Text.Trim().Equals(""))
            {

                resultado = false;
                return resultado;
            }
            else
            {
                resultado = true;
            }
            if (EsFecha(txtFecha.Text))
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;

        }

        private void CargarComboTiposDocumento()
        {
          

            try
            {

                cmbTipoDocumento.DataSource = AD_TipoDocumento.ObtenerTiposDocumento();
                cmbTipoDocumento.DisplayMember = "nombre";
                cmbTipoDocumento.ValueMember = "Id_Tipo_Documento";
                cmbTipoDocumento.SelectedIndex = -1;
            }


            catch (Exception)
            {

                MessageBox.Show("Error en cmbTipoDoc");
            }
            
        }

        private void CargarComboBarrio()
        {
          
            try
            {
               
                cmbBarrio.DataSource = AD_Barrios.ObtenerBarrios();
                cmbBarrio.DisplayMember = "nombre";
                cmbBarrio.ValueMember = "Id_Barrio";
                cmbBarrio.SelectedIndex = -1;
            }


            catch (Exception)
            {
                throw;

            }
         
        }

        private void CargarGrilla()
        {
           dgrEmpleado.DataSource = AD_Empleados.ObtenerListadoEmpleados();
     
        }


        private Empleado ObtenerDatosEmplelado()
        {

            Empleado em = new Empleado();
            em.Nombre = txtNombre.Text.Trim();
            em.Apellido = txtApellido.Text.Trim();

            if (txtLegajo.Text != "")
            {
                em.Legajo = int.Parse(txtLegajo.Text.Trim());
            }
            em.Calle = txtCalle.Text.Trim();
            em.NumeroCalle = Convert.ToInt32(txtAltura.Text.Trim());
            em.CUIL = Convert.ToInt32(txtCuil.Text.Trim());
            em.Documento = txtDocumento.Text.Trim();

            //tipo objeto a tipo int 
            em.TipoDocumento = (int)cmbTipoDocumento.SelectedValue;
            em.IdBarrio = (int)cmbBarrio.SelectedValue;
            em.FechaIngreso = DateTime.Parse(txtFecha.Text);
            return em;

        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            if (validarNoVacios())
            {
                Empleado em = ObtenerDatosEmplelado();

                bool resultado = AD_Empleados.AltaEmpleado(em);
                if (resultado)
                {
                    CargarGrilla();
                    MessageBox.Show("Empleado agregado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarComboTiposDocumento();
                    CargarComboBarrio();


                }
                else
                {
                    MessageBox.Show("Error al intentar agregar empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Algun campo no fue completado de forma correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

       

        private void dgrEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int indice = e.RowIndex;
                if (indice > -1)
                {
                    btnActualizar.Enabled = true;
                    DataGridViewRow filaSeleccionada = dgrEmpleado.Rows[indice];
                    string legajo = filaSeleccionada.Cells["Legajo"].Value.ToString();

                    Empleado emp = AD_Empleados.ObtenerEmpleado(legajo);

                    LimpiarCampos();
                    CargarCampos(emp);

                }


            }
        }


        private void CargarCampos(Empleado emp)
        {
            txtNombre.Text = emp.Nombre;
            txtApellido.Text = emp.Apellido;
            DateTime fecha = emp.FechaIngreso;
            string dia = "";
            string mes = "";
            string año = fecha.Date.Year.ToString();

            dia = fecha.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }

            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }

            txtFecha.Text = dia + mes + año;

            txtCuil.Text = emp.CUIL.ToString();
            txtDocumento.Text = emp.Documento;
            txtCalle.Text = emp.Calle;
            txtAltura.Text = emp.NumeroCalle.ToString();

            cmbTipoDocumento.SelectedValue = emp.TipoDocumento;
            cmbBarrio.SelectedValue = emp.IdBarrio;
            txtLegajo.Text = emp.Legajo.ToString();

        }


        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validarNoVacios())
            {
                Empleado emp = ObtenerDatosEmplelado();
                MessageBoxButtons botones = MessageBoxButtons.YesNo; DialogResult QuestionResult = MessageBox.Show("¿Está seguro que desea actualizar empleado?", "Empleado", botones, MessageBoxIcon.Warning);
                if (QuestionResult == DialogResult.Yes)
                {
                    bool resultado = AD_Empleados.ModificarEmpleado(emp);
                    if (resultado)
                    {
                        CargarGrilla();
                        MessageBox.Show("Empleado actualizado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarComboTiposDocumento();
                        CargarComboBarrio();

                    }
                    else
                    {
                        MessageBox.Show("Error al intentar actualizar empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show("Algun campo no fue completado de forma correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      

        private void btnBorrarEmpleado_Click(object sender, EventArgs e)
        {

            if (validarNoVacios())
            {

                Empleado emp = ObtenerDatosEmplelado();
                MessageBoxButtons botones = MessageBoxButtons.YesNo; DialogResult QuestionResult = MessageBox.Show("¿Está seguro que desea eliminar empleado?", "Empleado", botones, MessageBoxIcon.Warning);
                if (QuestionResult == DialogResult.Yes)
                {
                    bool resultado = AD_Empleados.EliminarEmpleado(emp);
                    if (resultado)
                    {
                        CargarGrilla();
                        MessageBox.Show("Empleado eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarComboTiposDocumento();
                        CargarComboBarrio();

                    }
                    else
                    {
                        MessageBox.Show("Error al intentar eliminar empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
            
        }
    

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
            {
        LimpiarCampos();
        }
    }

}