using CineBackEnd.Entidades;
using CineFrontEnd.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CineFrontEnd.Formularios
{
    public partial class FrmPeliculasSeleccionar : Form
    {
        int seleccionada = -1;
        List<Pelicula> peliculas;
        public FrmPeliculasSeleccionar()
        {
            InitializeComponent();

        }

        private void dtpFechaEstreno_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void FrmPeliculasSeleccionar_Load(object sender, EventArgs e)
        {
            AsyncCargarGenero();
            peliculas = new List<Pelicula>();
            txbAño.Enabled = false;
            txbTitulo.Enabled = false;
            cmbGenero.Enabled = false;



        }

        private void cbxFecha_CheckedChanged(object sender, EventArgs e)
        {
            CheckearChecks();
        }

        private void cbxGenero_CheckedChanged(object sender, EventArgs e)
        {
            CheckearChecks();
        }

        private void cbxTitulo_CheckedChanged(object sender, EventArgs e)
        {
            CheckearChecks();
        }



        private void btnSerch_Click(object sender, EventArgs e)
        {
            int anio;
            string titulo;
            int generoSelecto;
            //valido año
            if (cbxAñoEstreno.Checked == true)
            {
                if (int.TryParse(txbAño.Text, out _))
                {
                    anio = Convert.ToInt32(txbAño.Text);
                }
                else anio = -1;
            }
            else anio = -1;
            //valido titulo
            if (cbxTitulo.Checked == true)
            {
                if (txbTitulo.Text != string.Empty)
                { titulo = txbTitulo.Text; }
                else
                { titulo = "Nulo"; }
            }
            else titulo = "Nulo";

            //valido cmb genero
            if (cbxGenero.Checked == true)
            {
                if (cmbGenero.SelectedIndex > -1)
                { generoSelecto = Convert.ToInt32(cmbGenero.SelectedValue); }
                else { generoSelecto = -1; }


            }
            else generoSelecto = -1;



            AsyncCargarPeliculas(titulo, anio, generoSelecto);

            CargarDGV();

        }

        private void CargarDGV()
        {
            if (dgvPelicula.Rows.Count > 0)
            { dgvPelicula.Rows.Clear(); }
            foreach (Pelicula p in peliculas)
            {
                dgvPelicula.Rows.Add(p.Id, p.Titulo, p.Genero.Descripcion, p.FechaEstreno.ToString("dd/MM/yyyy"));


            }

        }

        private async void AsyncCargarPeliculas(string titulo, int anio, int genero)
        {
            string url = string.Format("https://localhost:7168/Peliculas/traer?titulo={0}&id_genero={1}&anioEstreno={2}", titulo, genero, anio);
            var resultado = await Cliente.GetInstance().GetAsync(url);
            if (peliculas.Count != 0) { peliculas.Clear(); }
            peliculas = JsonConvert.DeserializeObject<List<Pelicula>>(resultado);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmPelicula p = new FrmPelicula(false, -1);
            p.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (seleccionada > -1)
            {
                FrmPelicula p = new FrmPelicula(true, seleccionada);
                p.ShowDialog();
            }
            else MessageBox.Show("Debe seleccionar una PELICULA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvPelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow f = dgvPelicula.CurrentRow;
            seleccionada = Convert.ToInt32((f.Cells[0].Value.ToString()));




        }
        private async void AsyncCargarGenero()
        {
            string url = "https://localhost:7168/Peliculas/traerGeneros";
            var result = await Cliente.GetInstance().GetAsync(url);
            var generos = new List<Genero>();
            try
            {
                generos = JsonConvert.DeserializeObject<List<Genero>>(result);

            }
            catch (Exception)
            {
                // Si lanza la excepción es que es un solo elemento.
                var singleResult = JsonConvert.DeserializeObject<Genero>(result);

                generos.Add(singleResult);
            }
            cmbGenero.DataSource = generos;
            cmbGenero.ValueMember = "Id";
            cmbGenero.DisplayMember = "Descripcion";
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void CheckearChecks()
        {
            if (cbxTitulo.Checked == true) { txbTitulo.Enabled = true; }
            if (cbxTitulo.Checked == false) { txbTitulo.Enabled = false; }

            if (cbxAñoEstreno.Checked == true) { txbAño.Enabled = true; }
            else { txbAño.Enabled = false; }

            if (cbxGenero.Checked == true) { cmbGenero.Enabled = true; }
            else { cmbGenero.Enabled = false; }


        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro desea eliminar la pelicula?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DialogResult restult2 = MessageBox.Show("Esto podria eliminar las funciones  registradas que no emitieron " +
                "tickets", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (restult2 == DialogResult.Yes)
                {
                    if (seleccionada != -1)
                    {
                        AsyncBorrarPelicula(seleccionada);
                    }
                    else { MessageBox.Show("Seleccione una pelicula (se recomienda hacer doble click)"); }

                }
            }
        }

        private async Task AsyncBorrarPelicula(int id)
        {
            string url = string.Format("https://localhost:7168/Peliculas/borrar?id={0}", id);

            var result2 = await Cliente.GetInstance().DeleteAsync(url);

            if (result2.Equals("true"))
            {
                MessageBox.Show("Pelicula Eliminada", "INF+", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dgvPelicula.Rows.Count > 0) { dgvPelicula.Rows.Clear(); }
            }
            else
            {
                MessageBox.Show("ERROR..en el servidor No se pudo Eliminar la Pelicula intente luego", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }



    }
}
