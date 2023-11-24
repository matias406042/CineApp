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
using Newtonsoft.Json;
using CineFrontEnd.Http;

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

        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cboSeleccion.SelectedIndex == 0)
            {
                string url = "https://localhost:7168/PeliculasRep?selec=" + 1;
                var result = await Cliente.GetInstance().GetAsync(url);
                var dt = JsonConvert.DeserializeObject<DataTable>(result);
                reportViewer1.LocalReport.ReportEmbeddedResource = "CineFrontEnd.Reportes.rdlcPeliculasGenero.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
                reportViewer1.RefreshReport();
            }
            else if (cboSeleccion.SelectedIndex == 1)
            {
                string url = "https://localhost:7168/PeliculasRep?selec=" + 2;
                var result = await Cliente.GetInstance().GetAsync(url);
                var dt = JsonConvert.DeserializeObject<DataTable>(result);
                reportViewer1.LocalReport.ReportEmbeddedResource = "CineFrontEnd.Reportes.rdlcPeliculasClasificacion.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
                reportViewer1.RefreshReport();
            }
            else
            {
                string url = "https://localhost:7168/PeliculasRep?selec=" + 3;
                var result = await Cliente.GetInstance().GetAsync(url);
                var dt = JsonConvert.DeserializeObject<DataTable>(result);
                reportViewer1.LocalReport.ReportEmbeddedResource = "CineFrontEnd.Reportes.rdlcPeliculasProductora.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
                reportViewer1.RefreshReport();
            }
        }
    }
}
