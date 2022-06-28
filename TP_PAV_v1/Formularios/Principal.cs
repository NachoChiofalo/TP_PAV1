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
using TP_PAV_v1.Formularios;

namespace TP_PAV_v1.Entidades
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(Empleado emp)
        {
            InitializeComponent(); // establece y ejecuta todos los componentes 
            lblBienvenida.Text = "Bienvenido!";
            lblBienvenida.Visible = true;
        }



        private void Principal_Load(object sender, EventArgs e)
        {

        }
        private string NombreLogin(Empleado emp)
        {
            string legajo = emp.Legajo.ToString();
            string doc = emp.Documento;
            string nombre = "";
            try
            {
                nombre = ObtenerUsuario(doc, legajo);
                return nombre;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al recuperar el nombre de usuario.");
                return nombre;
            }

        }
        public static string ObtenerUsuario(string NroDoc, string Legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT nombre FROM Empleados WHERE @nroDoc = Nro_Documento AND @legajo =  legajo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDoc", NroDoc);
                cmd.Parameters.AddWithValue("@legajo", Legajo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                string resultado = (string)cmd.ExecuteScalar();
                return resultado;


            }
            catch (Exception ex)
            {

                return "";
            }
            finally
            {
                cn.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aBMLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMLocalidad ventana = new ABMLocalidad();
            ventana.Show();
        }

        private void aBMBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMBarrio ventana = new ABMBarrio();
            ventana.Show();
        }

        private void aBMCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCombustible ventana = new ABMCombustible();
            ventana.Show();
        }

        private void aBMCamionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCamion ventana = new ABMCamion();
            ventana.Show();
        }

        private void aBMTipoCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMTipoCombustible ventana = new ABMTipoCombustible();
            ventana.Show();
        }

        private void aBMEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMEmpleados ventana = new ABMEmpleados();
            ventana.Show();
        }

        private void aBMVariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMSucursal ventana = new ABMSucursal();
            ventana.Show();
        }

        private void aBMTipoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMTipoDocumento ventana = new ABMTipoDocumento();
            ventana.Show();
        }

        private void aBMEstacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMEstacion ventana = new ABMEstacion();
            ventana.Show();
        }

        private void aBMMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMMarca ventana = new ABMMarca();
            ventana.Show();
        }

        private void aBMProvinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProvincia ventana = new ABMProvincia();
            ventana.Show();

        }

        private void aBMTanqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMTanque ventana = new ABMTanque();
            ventana.Show();
        }

        private void aBMTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMTurno ventana = new ABMTurno();
            ventana.Show();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaRemito ventana = new AltaRemito();
            ventana.ShowDialog();
        }

        private void listadoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteListadoCamiones ventana = new ReporteListadoCamiones();
            ventana.ShowDialog();
        }

        private void listadoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEmpeados ventana = new ReporteEmpeados();
            ventana.ShowDialog();
        }

        private void listadoDeMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteListadoMarcas ventana = new ReporteListadoMarcas();
            ventana.ShowDialog();
        }
    }
    
}
