using CineBackEnd.Datos.Implementacion;
using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Entidades;
using CineFrontEnd.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineFrontEnd.Http;
using Newtonsoft.Json;

namespace CineFrontEnd.Formularios
{
    public partial class FrmPelicula : Form
    {
        Pelicula pelicula;
        bool editar;
        IPeliculaDao dao;
        bool activo;

        public FrmPelicula()
        {
            dao = new PeliculaDao();
            editar = false;
            activo = false;
            InitializeComponent();
            AsyncCargarGenero();
            AsyncCargarClasificacion();
            AsyncCargarProductora();
        }

        private async void AsyncCargarGenero()
        {
            string url = "https://localhost:7168/Peliculas/traerGeneros";
            var result = await Cliente.GetInstance().GetAsync(url);
            var generos = JsonConvert.DeserializeObject<List<Genero>>(result);

            cboGenero.DataSource = generos;
            cboGenero.ValueMember = "Id";
            cboGenero.DisplayMember = "Descripcion";
        }

        private async void AsyncCargarClasificacion()
        {
            string url = "https://localhost:7168/Peliculas/traerClasificaciones";
            var result = await Cliente.GetInstance().GetAsync(url);
            var clasificaciones = JsonConvert.DeserializeObject<List<ClasificacionPelicula>>(result);

            cboGenero.DataSource = clasificaciones;
            cboGenero.ValueMember = "Id";
            cboGenero.DisplayMember = "Descripcion";
        }

        private async void AsyncCargarProductora()
        {
            string url = "https://localhost:7168/Peliculas/traerProductoras";
            var result = await Cliente.GetInstance().GetAsync(url);
            var prod = JsonConvert.DeserializeObject<List<Productora>>(result);

            cboGenero.DataSource = prod;
            cboGenero.ValueMember = "Id";
            cboGenero.DisplayMember = "Descripcion";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
