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
using Newtonsoft.Json;
using CineFrontEnd.Http;

namespace CineFrontEnd.Formularios
{
    public partial class FrmComprobante : Form
    {
        Comprobante comprobante;
        IComprobanteDao dao;
        IFuncionDao fdao;
        List<Ticket> ticketList;
        public FrmComprobante()
        {
            InitializeComponent();
            comprobante = new Comprobante();
            dao = new ComprobanteDao();
            fdao = new FuncionDao();
            AsyncCargarPagos();
            AsyncCargarDecuento();
            txtTotal.Text = CalcularTotal().ToString();
            ticketList = new List<Ticket>();
        }
        private double CalcularTotal()
        {
            double total = 0;
            foreach (DataGridViewRow r in dgvTickets.Rows)
            {
                total += Convert.ToDouble(r.Cells["ColPrecio"].Value);
            }
            if (cbxDescuento.Checked)
                return total - (total / 100) * Convert.ToDouble(lblDescuento.Text.Substring(0, 2));
            else return total;
        }
  

        private async void AsyncCargarDecuento()
        {
            string url = "https://localhost:7168/comprobantes/getDescuentos";
            var result = await Cliente.GetInstance().GetAsync(url);
            var descuentos = JsonConvert.DeserializeObject<List<Descuento>>(result);

            cboDescuento.DataSource = descuentos;
            cboDescuento.DisplayMember = "Motivo";
            cboDescuento.ValueMember = "Id";
            cboDescuento.SelectedIndex = -1;
        }
        private async void AsyncCargarPagos()
        {
            string url = "https://localhost:7168/comprobantes/FormasPago";
            var result = await Cliente.GetInstance().GetAsync(url);
            var formaPagos = JsonConvert.DeserializeObject<List<FormaPago>>(result);

            cboFormaPago.DataSource = formaPagos;
            cboFormaPago.DisplayMember = "Forma";
            cboFormaPago.ValueMember = "Id";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // realizar el insert que devuelva un output int que vamos a usar para mostrar un reporte del
            // comprobante a travez del cliente http
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            comprobante.FormaPAgo.Id = (int)cboFormaPago.SelectedValue;
            comprobante.Total = CalcularTotal();
            if (cbxDescuento.Checked)
                comprobante.Descuento.Id = (int)cboDescuento.SelectedValue;
            else comprobante.Descuento.Id = 0;
            if (dao.Crear(comprobante))
                MessageBox.Show("Se creo con exito el comprobante", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {

                foreach (Ticket ticket in comprobante.Tickets)
                {
                    fdao.OcuparButaca(false, ticket.Id, ticket.Butaca.Fila, ticket.Butaca.Columna);
                }

                MessageBox.Show("Hubo un error al crear el combrobante", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();

            }
        }

        private void btnTicket_Click_1(object sender, EventArgs e)
        {
            int idTicket = dgvTickets.Rows.Count;
            FrmTicket ti = new FrmTicket(idTicket + 1, ticketList);
            //AddOwnedForm(ti);
            ti.ShowDialog();
            comprobante.Tickets = ticketList;
            //ticketList.Clear();
            dgvTickets.Rows.Clear();
            foreach (Ticket t in ticketList)
            {
                //ticketList.Add(t);
                string desde = $"{t.Funcion.HorarioInicio.Hour.ToString()}:{t.Funcion.HorarioInicio.Minute.ToString()}:{t.Funcion.HorarioInicio.Second.ToString()}";
                string hasta = $"{t.Funcion.HorarioFin.Hour.ToString()}:{t.Funcion.HorarioFin.Minute.ToString()}:{t.Funcion.HorarioFin.Second.ToString()}";
                dgvTickets.Rows.Add(new object[]
                {
                        t.Funcion.Pelicula,
                        t.Funcion.Sala.Descripcion,
                        $"{desde} A {hasta}",
                        t.Butaca.ToString(),
                        t.Funcion.Sala.Precio,
                        "Borrar"
                });
            }
        }

        //private void cboTicket_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Ticket t = (Ticket)cboTicket.SelectedItem;
        //    comprobante.AgregarTicket(t);
        //    string desde = $"{t.Funcion.HorarioInicio.Hour.ToString()}:{t.Funcion.HorarioInicio.Minute.ToString()}:{t.Funcion.HorarioInicio.Second.ToString()}";
        //    string hasta = $"{t.Funcion.HorarioFin.Hour.ToString()}:{t.Funcion.HorarioFin.Minute.ToString()}:{t.Funcion.HorarioFin.Second.ToString()}";
        //    dgvTickets.Rows.Add(new object[]
        //    {
        //        t.Funcion.Pelicula,
        //        t.Funcion.Sala.Descripcion,
        //        $"{desde} A {hasta}",
        //        t.Butaca.ToString(),
        //        t.Funcion.Sala.Precio,
        //        "Borrar"
        //    });
        //    txtTotal.Text = CalcularTotal().ToString();
        //}

        private void FrmComprobante_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDescuento.Checked)
            {
                cboDescuento.Enabled = true;
                cboDescuento.SelectedIndex = 0;
            }
            else
            {
                cboDescuento.Enabled = false;
                cboDescuento.SelectedIndex = -1;
            }
        }

        private void cboDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDescuento.SelectedIndex == -1)
            {
                lblDescuento.Visible = false;
                txtTotal.Text = CalcularTotal().ToString();
            }
            else
            {
                lblDescuento.Visible = true;
                lblDescuento.Text = cboDescuento.SelectedItem.ToString();
                txtTotal.Text = CalcularTotal().ToString();
            }
        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 & e.ColumnIndex == 5)
            {
                fdao.OcuparButaca(false, comprobante.Tickets[e.RowIndex].Funcion.Id,
                                        comprobante.Tickets[e.RowIndex].Butaca.Fila,
                                        comprobante.Tickets[e.RowIndex].Butaca.Columna);
                comprobante.EliminarTicket(e.RowIndex);
                //cboTicket.Items.RemoveAt(e.RowIndex);
                dgvTickets.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void cboTicket_DataSourceChanged(object sender, EventArgs e)
        {
            //Ticket t = (Ticket)cboTicket.SelectedItem;
            //comprobante.AgregarTicket(t);
            //string desde = $"{t.Funcion.HorarioInicio.Hour.ToString()}:{t.Funcion.HorarioInicio.Minute.ToString()}:{t.Funcion.HorarioInicio.Second.ToString()}";
            //string hasta = $"{t.Funcion.HorarioFin.Hour.ToString()}:{t.Funcion.HorarioFin.Minute.ToString()}:{t.Funcion.HorarioFin.Second.ToString()}";
            //dgvTickets.Rows.Add(new object[]
            //{
            //        t.Funcion.Pelicula,
            //        t.Funcion.Sala.Descripcion,
            //        $"{desde} A {hasta}",
            //        t.Butaca.ToString(),
            //        t.Funcion.Sala.Precio,
            //        "Borrar"
            //});
            //txtTotal.Text = CalcularTotal().ToString();
            //ticketList.Clear();
            //dgvTickets.Rows.Clear();
            //foreach (Ticket t in cboTicket.Items)
            //{     
            //    ticketList.Add(t);
            //    string desde = $"{t.Funcion.HorarioInicio.Hour.ToString()}:{t.Funcion.HorarioInicio.Minute.ToString()}:{t.Funcion.HorarioInicio.Second.ToString()}";
            //    string hasta = $"{t.Funcion.HorarioFin.Hour.ToString()}:{t.Funcion.HorarioFin.Minute.ToString()}:{t.Funcion.HorarioFin.Second.ToString()}";
            //    dgvTickets.Rows.Add(new object[]
            //    {
            //            t.Funcion.Pelicula,
            //            t.Funcion.Sala.Descripcion,
            //            $"{desde} A {hasta}",
            //            t.Butaca.ToString(),
            //            t.Funcion.Sala.Precio,
            //            "Borrar"
            //    });
            //}
        }

        private void lblDescuento_Click(object sender, EventArgs e)
        {

        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
