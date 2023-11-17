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
    public partial class FrmFuncion : Form
    {
        Funcion funcion;
        bool editar;
        IFuncionDao dao;

        public FrmFuncion()
        {
            InitializeComponent();
            dao = new FuncionDao();
            CargarSalas();
            CargarGeneros();
        }

        private void CargarGeneros()
        {
            List<Genero> lstGeneros = dao.GetGeneros();
            cboGenero.DataSource = lstGeneros;
            cboGenero.ValueMember = "Id";
            cboGenero.DisplayMember = "Descripcion";
        }

        private void CargarSalas()
        {
            List<Sala> lstSalas = dao.GetSalas();
            cboSala.DataSource = lstSalas;
            cboSala.ValueMember = "Id";
            cboSala.DisplayMember = "Descripcion";
        }

        public FrmFuncion(Funcion f)
        {
            InitializeComponent();
            funcion = f;
            
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {

        }

        private void FrmFuncion_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                btnInsert.Text = "EDITAR";
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDimension.Text = cboSala.SelectedItem.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validar Datos
            List<Pelicula> pelis = dao.Peliculas(txtTitulo.Text, DateTime.MinValue, int.Parse(cboGenero.SelectedValue.ToString()));
            dgvPelis.Rows.Clear();
            foreach (Pelicula p in pelis)
            {
                dgvPelis.Rows.Add(new object[] {p.Id,p.Titulo,p.Genero.Descripcion,p.Duracion,
                    p.Director.ToString(),p.FechaEstreno.ToShortDateString(),p.Clasificacion.EdadMinima,p.Productora.Nombre});
            }
        }
    }
}
