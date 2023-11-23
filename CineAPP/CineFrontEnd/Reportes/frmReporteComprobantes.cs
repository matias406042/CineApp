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
using CineFrontEnd.Http;
using Newtonsoft.Json;
using CineBackEnd.Entidades;

namespace CineFrontEnd.Reportes
{
    public partial class frmReporteComprobantes : Form
    {
        IComprobanteDao dao;
        public frmReporteComprobantes()
        {
            InitializeComponent();
            dao = new ComprobanteDao();
        }

        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            string url = string.Format("https://localhost:7168/comprobantes?desde={0}&hasta={1}", dtpDesde.Value.ToString("yyyy-MM-dd"), dtpHasta.Value.ToString("yyyy-MM-dd"));
            //DataTable dt = dao.GetComprobantes(dtpDesde.Value,dtpHasta.Value);
            var result = await Cliente.GetInstance().GetAsync(url);
            var dt = JsonConvert.DeserializeObject<DataTable>(result);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
        }

        private void frmReporteComprobantes_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "CineFrontEnd.Reportes.rdlcComprobantes.rdlc";
        }
    }
}
