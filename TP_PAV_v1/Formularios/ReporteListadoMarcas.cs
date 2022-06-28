using Microsoft.Reporting.WinForms;
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
    public partial class ReporteListadoMarcas : Form
    {
        public ReporteListadoMarcas()
        {
            InitializeComponent();
        }

 

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Marcas.ObtenerMarcas();
            ReportDataSource ds = new ReportDataSource("DatosDeMarcas", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
