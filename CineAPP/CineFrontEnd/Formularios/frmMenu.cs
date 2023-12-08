﻿using CineBackEnd.Entidades;
using CineFrontEnd.Reportes;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            esconderSubMenu();
        }




        private void btnFunciones_Click(object sender, EventArgs e)
        {
            //FrmFuncionesSeleccionar frmfuncionseleccionar = new FrmFuncionesSeleccionar();

            //frmfuncionseleccionar.ShowDialog();
            lblMenu.Text = "Funciones";
            esconderSubMenu();
            abrirFormHijo(new FrmFuncionesSeleccionar());
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {

            //FrmPeliculasSeleccionar frmPeliculaSeleccionar = new FrmPeliculasSeleccionar();
            //frmPeliculaSeleccionar.ShowDialog();
            lblMenu.Text = "Seleccionar Película";
            esconderSubMenu();
            abrirFormHijo(new FrmPeliculasSeleccionar());

            //FrmPeliculasSeleccionar frmPeliculaSeleccionar = new FrmPeliculasSeleccionar();
            //frmPeliculaSeleccionar.ShowDialog();





        }

        private void btnTickets_Click(object sender, EventArgs e)///ESTE ES EL BOTON REPORTES
        {
            mostrarSubMenu(subPanelReportes);
            //if (MessageBox.Show("Que reporte desea consultar?", "Seleccionar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    frmReporteComprobantes frmReporteComprobantes = new frmReporteComprobantes();
            //    frmReporteComprobantes.ShowDialog();
            //}
            //else
            //{
            //    frmReportePeliculas frmReportePeliculas = new frmReportePeliculas();
            //    frmReportePeliculas.ShowDialog();
            //}


        }

        //private void btnComprobantes_Click(object sender, EventArgs e)
        //{
        //    //FrmComprobante frmComp = new FrmComprobante();
        //    //frmComp.ShowDialog();
        //    abrirFormHijo(new FrmComprobante());
        //}

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }



        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private Form formActivo = null;
        private void abrirFormHijo(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelFrms.Controls.Add(formHijo);
            panelFrms.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        private void esconderSubMenu()
        {
            if (subPanelReportes.Visible == true)
                subPanelReportes.Visible = false;
        }

        private void mostrarSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                esconderSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void cambiar_Label(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnRep_Comprobantes_Click(object sender, EventArgs e)
        {

        }

        private void btnRep_Peliculas_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Menú Principal";
            if (formActivo != null)
                formActivo.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            //button.Size = new Size((int)(button.Width * 1.1), (int)(button.Height * 1.1));
            //pictureBox2.Visible = false;
            pictureBox2.BackColor = Color.FromArgb(100, 00, 00);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            //button.Size = new Size((int)(button.Width / 1.1), (int)(button.Height / 1.1));
            //pictureBox2.Visible = true;
            pictureBox2.BackColor = Color.FromArgb(50, 0, 0);
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Argüello Grachot Facundo \nBon Matías Nicolás\nColazo Federico Tomás \nLópez Juan Martín \nTabares Iván \nZarza Mateo", "Integrantes");
        }

        private void button1_Click(object sender, EventArgs e)// BOTON REPORTES COMPROBANTE
        {
            lblMenu.Text = "Reporte: Comprobantes";
            esconderSubMenu();
            abrirFormHijo(new frmReporteComprobantes());

        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            lblMenu.Text = "Comprobantes";
            esconderSubMenu();
            abrirFormHijo(new FrmComprobante());
        }

        private void button2_Click(object sender, EventArgs e)// BOTON REPORTE PELICULAS
        {
            lblMenu.Text = "Reporte: Películas";
            esconderSubMenu();
            abrirFormHijo(new frmReportePeliculas());
        }
    }
}
