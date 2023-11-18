using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineBackEnd.Entidades;
using CineBackEnd.Datos.Implementacion;
using CineBackEnd.Datos.Interfaz;

namespace CineFrontEnd.Formularios
{
    public partial class FrmTicket : Form
    {
        IFuncionDao fDao;
        string butaca;
        List<Funcion> funciones;
        int idTick;
        public FrmTicket(int id)
        {
            InitializeComponent();
            fDao = new FuncionDao();
            idTick = id;
        }



        private void FrmTicket_Load(object sender, EventArgs e)
        {
            
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnButacas_Click(object sender, EventArgs e)
        {
            frmButacas butacas = new frmButacas();
            AddOwnedForm(butacas);
            butacas.ShowDialog();
        }

        private void cbxTitulo_CheckedChanged_1(object sender, EventArgs e)
        {
            txbTitulo.Enabled = !txbTitulo.Enabled;
        }

        private void cbxFecha_CheckedChanged_1(object sender, EventArgs e)
        {
            dtpFecha.Enabled = !dtpFecha.Enabled;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            funciones = new List<Funcion>();
            if(cbxTitulo.Checked & cbxFecha.Checked)           
                funciones = fDao.GetFunciones(dtpFecha.Value, txbTitulo.Text);          
            else if(cbxTitulo.Checked & !cbxFecha.Checked)
                funciones = fDao.GetFunciones(DateTime.MinValue, txbTitulo.Text);
            else if(!cbxTitulo.Checked & cbxFecha.Checked)
                funciones = fDao.GetFunciones(dtpFecha.Value, String.Empty);
            else
                funciones = fDao.GetFunciones(DateTime.MinValue, "");
            dgvFunciones.Rows.Clear();
            foreach (Funcion f in funciones)
            {
                dgvFunciones.Rows.Add(new object[]
                {
                    f.Id,
                    f.Pelicula.Titulo,
                    f.HorarioInicio,
                    f.HorarioFin,
                    f.Sala.Descripcion,
                    f.Sala.Tipo.Descripcion,
                    f.Sala.Precio               
                });
            }
        }

        private void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 & e.RowIndex != -1)
            {
                foreach  (DataGridViewRow fila in dgvFunciones.Rows)
                {
                    if (fila.Index == e.RowIndex)
                       fila.Cells[7].Value = true;
                    else
                        fila.Cells[7].Value = false;
                }
            }
                
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validar datos
            FrmComprobante comprobanteForm = Owner as FrmComprobante;
            foreach (DataGridViewRow fila in dgvFunciones.Rows)
            {
                if((bool)fila.Cells[7].Value)
                {
                    Funcion f = new Funcion();
                    Ticket t = new Ticket();
                    foreach (Funcion ff in funciones)
                    {
                        if ((int)fila.Cells[0].Value == ff.Id)
                        {
                            f = ff;
                            break;
                        }
                            
                    }
                    t.Funcion = f;
                    t.Precio = Convert.ToDouble(f.Sala.Precio);
                    t.Butaca.Columna = Convert.ToInt32(txtButaca.Text.Substring(1));
                    t.Butaca.Fila = txtButaca.Text.Substring(0, 1);
                    comprobanteForm.cboTicket.Items.Add(t);
                    comprobanteForm.cboTicket.SelectedIndex ++ ;
                    this.Dispose();
                }
            }
        }
    }
}
