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
using CineFrontEnd.Http;
using Newtonsoft.Json;

namespace CineFrontEnd.Formularios
{
    public partial class FrmTicket : Form
    {
        //IFuncionDao fDao;
        string butaca;
        List<Funcion> funciones;
        int idTick;
        List<Ticket> ticketList;
        public FrmTicket(int id, List<Ticket> ticketlist)
        {
            InitializeComponent();
            //fDao = new FuncionDao();
            idTick = id;
            this.ticketList = ticketlist;
        }



        private void FrmTicket_Load(object sender, EventArgs e)
        {

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

        private async void btnButacas_Click(object sender, EventArgs e)
        {
            Funcion funcionElegida = new Funcion();
            foreach (DataGridViewRow fila in dgvFunciones.Rows)
            {
                if ((bool)fila.Cells[7].Value == true)
                {
                    foreach (Funcion f in funciones)
                    {
                        if ((int)fila.Cells[0].Value == f.Id)
                        {
                            funcionElegida = f;
                            break;
                        }
                    }
                    break;
                }
            }
            string url = String.Format("https://localhost:7168/Butacas/traerid?id_funcion={0}",funcionElegida.Id); 
            var result = await Cliente.GetInstance().GetAsync(url);
            var lstbutacas = JsonConvert.DeserializeObject<List<Butaca>>(result);
            //frmButacas butacas = new frmButacas(ButacaDao.ObtenerInstancia().ObtenerButacasXFuncion(funcionElegida.Id));
            frmButacas butacas = new frmButacas(lstbutacas);
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dgvFunciones.Rows.Clear();
            funciones = new List<Funcion>();
            string url = "";
            if (cbxTitulo.Checked & txbTitulo.Text != String.Empty)
            {
                url = string.Format("https://localhost:7168/Funciones/traerFunciones?fecha={0}&titulo={1}", dtpFecha.Value.ToString("yyyy-MM-dd"), txbTitulo.Text);
            }
            else
            {
                url = string.Format("https://localhost:7168/Funciones/traerFunciones?fecha={0}&titulo=12365448632163s6sd6f", dtpFecha.Value.ToString("yyyy-MM-dd"));
            }
            var result = await Cliente.GetInstance().GetAsync(url);
            var lstfunciones = JsonConvert.DeserializeObject<List<Funcion>>(result);
            //if (cbxTitulo.Checked & cbxFecha.Checked)
            //    funciones = fDao.GetFunciones(dtpFecha.Value, txbTitulo.Text);
            //else if (cbxTitulo.Checked & !cbxFecha.Checked)
            //    funciones = fDao.GetFunciones(DateTime.MinValue, txbTitulo.Text);
            //else if (!cbxTitulo.Checked & cbxFecha.Checked)
            //    funciones = fDao.GetFunciones(dtpFecha.Value, String.Empty);
            //else
            //    funciones = fDao.GetFunciones(DateTime.MinValue, "");
            funciones = lstfunciones;
            //VALIDACION UWU

            if (funciones.Count <= 0)
            {
                MessageBox.Show("No se han encontrado resultados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //
            dgvFunciones.Rows.Clear();
            txtButaca.Text = string.Empty;
            btnButacas.Enabled = false;
            foreach (Funcion f in funciones)
            {
                dgvFunciones.Rows.Add(new object[]
                {
                    f.Id,
                    f.Pelicula.Titulo,
                    f.HorarioInicio.ToShortTimeString(),
                    f.HorarioFin.ToShortTimeString(),
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
                foreach (DataGridViewRow fila in dgvFunciones.Rows)
                {
                    if (fila.Index == e.RowIndex)
                        fila.Cells[7].Value = true;
                    else
                        fila.Cells[7].Value = false;
                }
                btnButacas.Enabled = true;
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //Validar datos
            FrmComprobante comprobanteForm = Owner as FrmComprobante;

            if (funciones == null)
            {
                MessageBox.Show("Debes buscar una función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // validados uwu
            //FrmComprobante comprobanteForm = Owner as FrmComprobante;


            foreach (DataGridViewRow fila in dgvFunciones.Rows)
            {
                if (fila.Cells[7].Value == null)
                {
                    MessageBox.Show("Se debe elegir una función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                if ((bool)fila.Cells[7].Value)
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

                    if(txtButaca.Text != string.Empty)
                    {

                        //aaaaaaaaaaaaaaaaaaaaaaaa
                        t.Funcion = f;
                        t.Precio = Convert.ToDouble(f.Sala.Precio);
                        t.Butaca.Columna = Convert.ToInt32(txtButaca.Text.Substring(1));
                        t.Butaca.Fila = txtButaca.Text.Substring(0, 1);
                        t.Butaca.Estado = "Ocupada";
                        string url1 = "https://localhost:7168/Butaca/ocupar";
                        string bodycontent = JsonConvert.SerializeObject(t);
                        var result2 = await Cliente.GetInstance().PutAsync(url1, bodycontent);
                        ticketList.Add(t);
                        //comprobanteForm.cboTicket.DataSource = ticketList;
                        this.Dispose();

                        
                    }
                    else MessageBox.Show("Se debe elegir una butaca", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }

        private void FrmTicket_Load_1(object sender, EventArgs e)
        {

        }
    }
}
