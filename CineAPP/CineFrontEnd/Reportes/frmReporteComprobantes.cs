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
    public partial class frmReporteComprobantes : Form
    {
        IComprobanteDao dao;
        public frmReporteComprobantes()
        {
            InitializeComponent();
            dao = new ComprobanteDao();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable dt = dao.GetComprobantes(dtpDesde.Value,dtpHasta.Value);
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
