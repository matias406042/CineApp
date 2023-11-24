using CineBackEnd.Entidades;
using CineFrontEnd.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFrontEnd.Formularios
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnFunciones_Click(object sender, EventArgs e)
        {
            FrmFuncionesSeleccionar frmfuncionseleccionar = new FrmFuncionesSeleccionar();

            frmfuncionseleccionar.ShowDialog();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            FrmPeliculasSeleccionar frmPeliculaSeleccionar = new FrmPeliculasSeleccionar();
            frmPeliculaSeleccionar.ShowDialog();
           



        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Que reporte desea consultar?", "Seleccionar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmReporteComprobantes frmReporteComprobantes = new frmReporteComprobantes();
                frmReporteComprobantes.ShowDialog();
            }
            else
            {
                frmReportePeliculas frmReportePeliculas = new frmReportePeliculas();
                frmReportePeliculas.ShowDialog();
            }


        }

        private void btnComprobantes_Click(object sender, EventArgs e)
        {
            FrmComprobante frmComp = new FrmComprobante();
            frmComp.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
