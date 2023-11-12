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

        private void btnSave_Click(object sender, EventArgs e)
        {
            FrmComprobante ventanaUno = this.Owner as FrmComprobante;
            if (ventanaUno != null)
            {
                // Realizar llenado de dgvTickets de la ventanaUno con el ticket creado
              
                this.Dispose();
            }
        }
    }
}
