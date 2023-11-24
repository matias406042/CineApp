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
using System.Linq.Expressions;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;
using CineFrontEnd.Reportes;
using System.Text.Json.Nodes;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;
using System.Windows.Forms.Layout;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System.Threading.Tasks.Sources;

namespace CineFrontEnd.Formularios
{
    public partial class FrmPelicula : Form
    {
        Pelicula pelicula;
        bool editar;
        IPeliculaDao dao;
        int idPelicula;

        public FrmPelicula(bool aux,int id )
        {
            dao = new PeliculaDao();
            editar = aux;
            this.idPelicula = id;
           
           
            pelicula = new Pelicula();
            InitializeComponent();

        }
         private async Task AsyncCargarPelicula(int id)
        {
            string url = string.Format("https://localhost:7168/Peliculas/traerXID?id_pelicula={0}", id);
            
            var result = await Cliente.GetInstance().GetAsync(url);

            var peliculavar = JsonConvert.DeserializeObject<Pelicula>(result);

            pelicula = peliculavar;

            
        }
    

        private async Task AsyncCargarGenero()
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
            cboGenero.DataSource = generos;
            cboGenero.ValueMember = "Id";
            cboGenero.DisplayMember = "Descripcion";
        }


        private async Task AsyncCargarClasificacion()
        {
            string url = "https://localhost:7168/Peliculas/traerClasificaciones";
            var result1 = await Cliente.GetInstance().GetAsync(url);
            var clasificaciones = new List<ClasificacionPelicula>();
            try
            {
                clasificaciones = JsonConvert.DeserializeObject<List<ClasificacionPelicula>>(result1);

            }
            catch (Exception)
            {
                // Si lanza la excepción es que es un solo elemento.
                var singleResult = JsonConvert.DeserializeObject<ClasificacionPelicula>(result1);

                clasificaciones.Add(singleResult);
            }
            cboClasificacion.DataSource = clasificaciones;
            cboClasificacion.ValueMember = "Id";
            cboClasificacion.DisplayMember = "EdadMinima";
        }

        private async Task AsyncCargarProductora()
        {
            string url = "https://localhost:7168/Peliculas/traerProductora";
            var result2 = await Cliente.GetInstance().GetAsync(url);

            var productoras = new List<Productora>();
            try
            {
                productoras = JsonConvert.DeserializeObject<List<Productora>>(result2);

            }
            catch (Exception)
            {
                // Si lanza la excepción es que es un solo elemento.
                var singleResult = JsonConvert.DeserializeObject<Productora>(result2);

                productoras.Add(singleResult);
            }
            cboProductora.DataSource = productoras;
            cboProductora.ValueMember = "Id";
            cboProductora.DisplayMember = "Nombre";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            editar =false;
            this.Close();
        }

        private async void FrmPelicula_Load(object sender, EventArgs e)
        {
            
            pelicula = new Pelicula();
            await AsyncCargarGenero();
            await AsyncCargarClasificacion();
            await AsyncCargarProductora();
            if (editar)
            {
              await AsyncCargarPelicula(idPelicula);
            }
                CamposIniciar(editar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false) { AsyncGuardarPelicula(); }
            else { AsyncActualizarPelicula(); }

        }

        private async void AsyncActualizarPelicula()
        {
            if (RellenarPelicula(pelicula))
            {
                string url = "https://localhost:7168/Peliculas/actualizar";
                var body = JsonConvert.SerializeObject(pelicula);
                var result2 = await Cliente.GetInstance().PutAsync(url, body);
                if (result2.Equals("true"))
                {
                    MessageBox.Show("Pelicula Actualizada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CamposIniciar(editar);
                }
                else
                {
                    MessageBox.Show("ERROR. No se pudo actualizar la Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }

        private async void AsyncGuardarPelicula()
        {
            RellenarPelicula(pelicula);
            string url = "https://localhost:7168/Peliculas/cargar";
            var body = JsonConvert.SerializeObject(pelicula);
            var result2 = await Cliente.GetInstance().PostAsync(url, body);

            if (result2.Equals("true"))
            {
                MessageBox.Show("Pelicula registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CamposIniciar(editar);
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void CamposIniciar(bool aux)
        {if (aux == false)
            {
                txtTitulo.Text = string.Empty;
                txtDuracion.Text = string.Empty;
                cboClasificacion.SelectedIndex = 0;
                cboGenero.SelectedIndex = 0;
                cboProductora.SelectedIndex = 0;
            }
        if (aux==true)
            {
                txtTitulo.Text =pelicula.Titulo;
                txtDuracion.Text = Convert.ToString(pelicula.Duracion);
                cboClasificacion.SelectedValue = pelicula.Clasificacion.Id;
                cboGenero.SelectedValue = pelicula.Genero.Id;
                cboProductora.SelectedValue = pelicula.Productora.Id;
            }

        }
        private bool RellenarPelicula(Pelicula p)
        {
            bool aux = false;
            if (txtTitulo.Text != string.Empty)
            {
                p.Titulo = txtTitulo.Text;

            }
            else { MessageBox.Show("Se necesita un TITULO para crear la pelicula."); return aux; }
            if (txtDuracion.Text != string.Empty && int.TryParse(txtDuracion.Text, out _) == true)
            {

                p.Duracion = Convert.ToInt32(txtDuracion.Text);

            }
            else { MessageBox.Show("Ingrese un valor valido para DURACION EN MINUTOS"); return aux; }

            if (cboClasificacion.SelectedIndex != -1) { p.Clasificacion = (ClasificacionPelicula)cboClasificacion.SelectedItem; }
            else { MessageBox.Show("Seleccione una CLASIFICACION para su pelicula"); return aux; }

            if (cboGenero.SelectedIndex != -1) { p.Genero = (Genero)cboGenero.SelectedItem; }
            else { MessageBox.Show("Seleccione un GENERO para su pelicula"); return aux; }


            if (cboProductora.SelectedIndex != -1) { p.Productora = (Productora)cboProductora.SelectedItem; }
            else { MessageBox.Show("Seleccione una PRODUCTORA para la pelicula"); return aux; }
            if (dtpEstreno.Value < DateTime.Now.Date)
            {
                p.FechaEstreno = dtpEstreno.Value;
            }
            else {
                MessageBox.Show("Fecha no Valida");
                        return aux; }
            return true;
        }
        
    }
}
