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
    public partial class FrmFuncion : Form
    {
        int idModificar;
        string accion;
        public FrmFuncion()
        {
            InitializeComponent();
        }
        public FrmFuncion(int id, string acc)
        {
            InitializeComponent();
            idModificar = id;
            accion = acc.ToLower();
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {

        }

        private void FrmFuncion_Load(object sender, EventArgs e)
        {

        }
    }
}
