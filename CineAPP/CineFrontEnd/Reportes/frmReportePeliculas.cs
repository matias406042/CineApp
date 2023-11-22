using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineBackEnd.Datos.Implementacion;
using CineBackEnd.Datos.Interfaz;

namespace CineFrontEnd.Reportes
{
    public partial class frmReportePeliculas : Form
    {
        IPeliculaDao dao;
        public frmReportePeliculas()
        {
            InitializeComponent();
            dao = new PeliculaDao();
            cboSeleccion.SelectedIndex = 0;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(cboSeleccion.SelectedIndex == 0)
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "CineFrontEnd.Reportes.rdlcPeliculasGenero.rdlc";
                DataTable dt = dao.PeliculasReporte(1);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
                reportViewer1.RefreshReport();
            }
            else if(cboSeleccion.SelectedIndex == 1)
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "CineFrontEnd.Reportes.rdlcPeliculasClasificacion.rdlc";
                DataTable dt = dao.PeliculasReporte(2);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
                reportViewer1.RefreshReport();
            }
            else
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "CineFrontEnd.Reportes.rdlcPeliculasProductora.rdlc";
                DataTable dt = dao.PeliculasReporte(3);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
                reportViewer1.RefreshReport();
            }
        }
    }
}
