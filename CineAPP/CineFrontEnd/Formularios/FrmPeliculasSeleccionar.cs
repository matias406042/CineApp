using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFrontEnd.Formularios
{
    public partial class FrmPeliculasSeleccionar : Form
    {
        public FrmPeliculasSeleccionar()
        {
            InitializeComponent();
        }

        private void dtpFechaEstreno_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmPeliculasSeleccionar_Load(object sender, EventArgs e)
        {
            btnSerch.Enabled = false;

        }

        private void cbxFecha_CheckedChanged(object sender, EventArgs e)
        {
            ChequearElSearch();
            if (cbxFecha.Checked == true) { txbAño.Enabled = true; }
            else if (cbxFecha.Checked == false) { txbAño.Enabled = false; }
        }

        private void cbxGenero_CheckedChanged(object sender, EventArgs e)
        {
            ChequearElSearch();
            if (cbxGenero.Checked == true) { cmbGenero.Enabled = true; }
            else if (cbxGenero.Checked == false) { cmbGenero.Enabled = false; }
        }

        private void cbxTitulo_CheckedChanged(object sender, EventArgs e)
        {
            ChequearElSearch();
            if (cbxTitulo.Checked == true) { txbTitulo.Enabled = true; }
            else if (cbxTitulo.Checked == false) { txbTitulo.Enabled = false; }
        }



        private void btnSerch_Click(object sender, EventArgs e)
        {

        }

        private void ChequearElSearch()
        {
            if (cbxTitulo.Checked == true || cbxFecha.Checked == true || cbxGenero.Checked == true) { btnSerch.Enabled = true; }
            else { btnSerch.Enabled = false; }





        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
