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
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace CineFrontEnd.Formularios
{
    public partial class FrmComprobante : Form
    {
        Comprobante comprobante;
        //IComprobanteDao dao;
        //IFuncionDao fdao;
        List<Ticket> ticketList;
        public FrmComprobante()
        {
            InitializeComponent();
            comprobante = new Comprobante();
            //dao = new ComprobanteDao();
            //fdao = new FuncionDao();
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
            {
                try
                {
                    if (Convert.ToDouble(lblDescuento.Text.Substring(0, 2)) != 0)
                    {
                        return total - ((total / 100) * Convert.ToDouble(lblDescuento.Text.Substring(0, 2)));
                    }

                    else { return total; }
                }
                catch (Exception)
                {

                    return 0;
                }


            }
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




        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validaciones

            if (cboDescuento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe SELECCIONAR UN DESCUENTO");
                return;
            }
            comprobante.FormaPago = (FormaPago)cboFormaPago.SelectedItem;
            comprobante.Total = CalcularTotal();
            if (cbxDescuento.Checked)
                comprobante.Descuento = (Descuento)cboDescuento.SelectedItem;
            else
            {
                comprobante.Descuento = new Descuento(0, "", 0);
            }


            if (dgvTickets.Rows.Count <= 0)
            {
                MessageBox.Show("Se debe asignar al menos un ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                await GuardarComprobanteAsync();

        }

        private void btnTicket_Click_1(object sender, EventArgs e)
        {
            int idTicket = dgvTickets.Rows.Count;
            FrmTicket ti = new FrmTicket(idTicket + 1, ticketList);

            ti.ShowDialog();
            comprobante.Tickets = ticketList;

            dgvTickets.Rows.Clear();
            foreach (Ticket t in ticketList)
            {

                string desde = $"{t.Funcion.HorarioInicio.Hour.ToString()}:{t.Funcion.HorarioInicio.Minute.ToString()}:{t.Funcion.HorarioInicio.Second.ToString()}";
                string hasta = $"{t.Funcion.HorarioFin.Hour.ToString()}:{t.Funcion.HorarioFin.Minute.ToString()}:{t.Funcion.HorarioFin.Second.ToString()}";
                dgvTickets.Rows.Add(new object[]
                {
                        t.Funcion.Pelicula.Titulo,
                        t.Funcion.Sala.Descripcion,
                        $"{desde} A {hasta}",
                        t.Butaca.ToString(),
                        t.Funcion.Sala.Precio,
                        "Borrar"
                });
            }
        }

        private void FrmComprobante_Load(object sender, EventArgs e)
        {

        }

        private void cbxDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDescuento.Checked)
            {
                cboDescuento.Enabled = true;
                cboDescuento.SelectedIndex = -1;
            }
            else
            {
                cboDescuento.Enabled = false;
                cboDescuento.SelectedIndex = -1;
            }
        }

        private void cboDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDescuento.SelectedIndex == -1 || cboDescuento.SelectedItem.ToString() == "SIN DESCUENTO")
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

        private async void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 & e.ColumnIndex == 5)
            {
                string url = "https://localhost:7168/Butaca/desocupar";
                Ticket t = comprobante.Tickets[e.RowIndex];
                string bodycontent = JsonConvert.SerializeObject(t);
                var result = await Cliente.GetInstance().PutAsync(url, bodycontent);
                comprobante.EliminarTicket(e.RowIndex);
                dgvTickets.Rows.RemoveAt(e.RowIndex);
            }
        }
        private async Task GuardarComprobanteAsync()
        {
            string bodyContent = JsonConvert.SerializeObject(comprobante);
            string url = "https://localhost:7168/comprobante/save";
            var result = await Cliente.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Comprobante registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el Comprobante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (Ticket t in comprobante.Tickets)
                {
                    string url1 = "https://localhost:7168//Butaca/desocupar";
                    string bodycontent = JsonConvert.SerializeObject(t);
                    var result2 = await Cliente.GetInstance().PutAsync(url1, bodycontent);
                }
            }
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Ticket t in comprobante.Tickets)
            {
                string url = "https://localhost:7168/Butaca/desocupar";

                string bodycontent = JsonConvert.SerializeObject(t);
                var result = await Cliente.GetInstance().PutAsync(url, bodycontent);
            }
            this.Dispose();
        }

        private void lblFormaPago_Click(object sender, EventArgs e)
        {

        }

        private void dgvTickets_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txtTotal.Text = CalcularTotal().ToString();
        }

        private void dgvTickets_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvTickets.Rows.Count > 0)
            {
                txtTotal.Text = CalcularTotal().ToString();
            }
            else
            {
                txtTotal.Text = "0";
            }
        }

        private void cbxDescuento_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}