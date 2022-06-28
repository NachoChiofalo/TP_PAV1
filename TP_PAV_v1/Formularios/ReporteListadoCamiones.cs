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
    public partial class ReporteListadoCamiones : Form
    {
        public ReporteListadoCamiones()
        {
            InitializeComponent();
        }

        private void ReporteListadoCamiones_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Camiones.ObtenerListadoCamiones();
            ReportDataSource ds = new ReportDataSource("DatosCamiones", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();

            if (!txtMarcaReporte.Text.Equals(""))
            {
                tabla = AD_Camiones.ObtenerListadoCamionesXMarca(txtMarcaReporte.Text);
                ReportDataSource ds = new ReportDataSource("DatosCamiones", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
            else
            {
                tabla = AD_Camiones.ObtenerListadoCamiones();
                ReportDataSource ds = new ReportDataSource("DatosCamiones", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
            string alcance = "Camiones de una marca";

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcance);
            reportViewer1.LocalReport.SetParameters(parametros);
        }
                
        private void btnBuscarModelo_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if (!txtModeloReporte.Text.Equals(""))
            {
                tabla = AD_Camiones.ObtenerListadoCamionesXModelo(txtModeloReporte.Text);
                ReportDataSource ds = new ReportDataSource("DatosCamiones", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
            else
            {
                tabla = AD_Camiones.ObtenerListadoCamiones();
                ReportDataSource ds = new ReportDataSource("DatosCamiones", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
            string alcance = "Camiones de un modelo";

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcance);
            reportViewer1.LocalReport.SetParameters(parametros);


        }
    }
}
