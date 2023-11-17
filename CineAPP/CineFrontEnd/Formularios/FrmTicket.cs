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
    public partial class FrmTicket : Form
    {
        
        public FrmTicket()
        {
            InitializeComponent();
        }



        private void FrmTicket_Load(object sender, EventArgs e)
        {
            cmbButacas.Enabled = false;

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            FrmComprobante ventanaUno = this.Owner as FrmComprobante;
            if (ventanaUno != null)
            {
                // Realizar llenado de dgvTickets de la ventanaUno con el ticket creado

                this.Dispose();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbxTitulo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTitulo.Checked) { txbTitulo.Enabled = true; }
            else { txbTitulo.Enabled = false; }
        }

        private void cbxFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFecha.Checked) { dtpFecha.Enabled = true; }
            else { dtpFecha.Enabled = false; }
        }

        private void cmbButacas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
