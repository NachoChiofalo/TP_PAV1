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
    public partial class LoguinForm : Form
    {
        public LoguinForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtLegajo.Text.Equals("Usuario") || txtLegajo.Text.Equals("") || txtDocumento.Text.Equals("Contraseña") || txtDocumento.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Nombre de Legajo y Numero de Documento");
            }
            else
            {
                string legajoDeEmpleado = txtLegajo.Text;
                string nroDocEmpleado = txtDocumento.Text;
                bool resultado = false;

                try
                {
                    
                    resultado = AD_Usuarios.ValidarUsuario(legajoDeEmpleado, nroDocEmpleado);

                    if (resultado)
                    {
                        Empleado emp = new Empleado(legajoDeEmpleado, nroDocEmpleado);
                        PrincipalForm ventana = new PrincipalForm(emp);
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario Inexistente.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Base de datos no Encontrada.");
                   

                }

            }
        }
      

        private void LoguinForm_Load(object sender, EventArgs e)
        {

        }
    }
}
