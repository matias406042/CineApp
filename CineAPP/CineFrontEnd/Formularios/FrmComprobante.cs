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
    public partial class FrmComprobante : Form
    {
        public FrmComprobante()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // realizar el insert que devuelva un output int que vamos a usar para mostrar un reporte del
            // comprobante a travez del cliente http
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            FrmTicket t = new FrmTicket();
            AddOwnedForm(t);
            t.ShowDialog();
        }
    }
}
