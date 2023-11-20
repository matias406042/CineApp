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
    public partial class frmButacas : Form
    {
        List<Butaca> butacas;
        public frmButacas(List<Butaca> Butacas)
        {
            InitializeComponent();
            butacas = Butacas;
            CargarButacas();
        }

        private void CargarButacas()
        {

            foreach (var p in this.Controls.OfType<PictureBox>())
            {
                foreach (Butaca b in butacas)
                {
                    if (p.Name == b.ToString())
                    {
                        if (b.Estado == "Ocupada")
                        {
                            ((PictureBox)p).Image = Properties.Resources.ButacaRoja;
                            ((PictureBox)p).Enabled = false;
                            break;
                        }
                        else
                        {
                            ((PictureBox)p).Image = Properties.Resources.ButacaAzul;
                            ((PictureBox)p).Enabled = true;
                            break;
                        }

                    }

                }
            }
        }

        //private void btnA1_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "A1";
        //    this.Dispose();
        //}

        //private void btnA2_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "A2";
        //    this.Dispose();
        //}

        //private void btnA3_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "A3";
        //    this.Dispose();
        //}

        //private void btnA4_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "A4";
        //    this.Dispose();
        //}

        //private void btnA5_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "A5";
        //    this.Dispose();
        //}

        //private void btnA6_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "A6";
        //    this.Dispose();
        //}

        //private void btnA7_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "A7";
        //    this.Dispose();
        //}

        //private void btnB1_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "B1";
        //    this.Dispose();
        //}

        //private void btnB2_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "B2";
        //    this.Dispose();
        //}

        //private void btnB3_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "B3";
        //    this.Dispose();
        //}

        //private void btnB4_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "B4";
        //    this.Dispose();
        //}

        //private void btnB5_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "B5";
        //    this.Dispose();
        //}

        //private void btnB6_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "B6";
        //    this.Dispose();
        //}

        //private void btnB7_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "B7";
        //    this.Dispose();
        //}

        //private void btnC1_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "C1";
        //    this.Dispose();
        //}

        //private void btnC2_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "C2";
        //    this.Dispose();
        //}

        //private void btnC3_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "C3";
        //    this.Dispose();
        //}

        //private void btnC4_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "C4";
        //    this.Dispose();
        //}

        //private void btnC5_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "C5";
        //    this.Dispose();
        //}

        //private void btnC6_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "C6";
        //    this.Dispose();
        //}

        //private void btnC7_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "C7";
        //    this.Dispose();
        //}

        //private void btnD1_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "D1";
        //    this.Dispose();
        //}

        //private void btnD2_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "D2";
        //    this.Dispose();
        //}

        //private void btnD3_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "D3";
        //    this.Dispose();
        //}

        //private void btnD4_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "D4";
        //    this.Dispose();
        //}

        //private void btnD5_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "D5";
        //    this.Dispose();
        //}

        //private void btnD6_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "D6";
        //    this.Dispose();
        //}

        //private void btnD7_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "D7";
        //    this.Dispose();
        //}

        //private void btnF1_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "E1";
        //    this.Dispose();
        //}

        //private void btnF2_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "E2";
        //    this.Dispose();
        //}

        //private void btnF3_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "E3";
        //    this.Dispose();
        //}

        //private void btnF4_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "E4";
        //    this.Dispose();
        //}

        //private void btnF5_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "E5";
        //    this.Dispose();
        //}

        //private void btnF6_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "E6";
        //    this.Dispose();
        //}

        //private void btnF7_Click(object sender, EventArgs e)
        //{
        //    FrmTicket ticket = Owner as FrmTicket;
        //    ticket.txtButaca.Text = "E7";
        //    this.Dispose();
        //}

        private void frmButacas_Load(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void A1_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void A2_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void A3_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void A4_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void A5_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();

        }

        private void A6_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();

        }

        private void A7_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();

        }

        private void B1_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();

        }

        private void B2_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void B4_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void B5_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void B6_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void B7_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void C1_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void C2_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void C3_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void C4_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void C5_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void C6_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void C7_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void D1_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void D2_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void D3_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void D4_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void D5_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void D6_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void D7_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void E1_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void E2_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void E3_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void E4_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void E5_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void E6_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }

        private void E7_Click(object sender, EventArgs e)
        {
            FrmTicket ticket = Owner as FrmTicket;
            ticket.txtButaca.Text = ((PictureBox)sender).Name;
            this.Dispose();
        }
    }
}
