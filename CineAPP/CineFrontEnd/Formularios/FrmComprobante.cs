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

namespace CineFrontEnd.Formularios
{
    public partial class FrmComprobante : Form
    {
        Comprobante comprobante;
        public FrmComprobante()
        {
            InitializeComponent();
            comprobante = new Comprobante();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // realizar el insert que devuelva un output int que vamos a usar para mostrar un reporte del
            // comprobante a travez del cliente http
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnTicket_Click_1(object sender, EventArgs e)
        {
            int idTicket = dgvTickets.Rows.Count;
            FrmTicket t = new FrmTicket(idTicket + 1);
            AddOwnedForm(t);
            t.ShowDialog();
        }

        private void cboTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ticket t = (Ticket)cboTicket.SelectedItem;
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

        private void FrmComprobante_Load(object sender, EventArgs e)
        {
            
        }
    }
}
