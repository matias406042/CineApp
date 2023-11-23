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
using System.Diagnostics.Eventing.Reader;
using CineFrontEnd.Http;
using Newtonsoft.Json;

namespace CineFrontEnd.Formularios
{
    public partial class FrmFuncion : Form
    {
        Funcion funcion;
        bool editar;
        IFuncionDao dao;
        List<Pelicula> pelis;
        bool activo;

        public FrmFuncion()
        {
            InitializeComponent();
            dao = new FuncionDao();
            editar = false;
            activo = false;
            AsyncCargarSalas();
            AsyncCargarGeneros();
            dtpFecha.MinDate = DateTime.Now;
            dtpInicio.ShowUpDown = true;
            dtpFin.ShowUpDown = true;
        }



        private async void AsyncCargarGeneros()
        {
            string url = "https://localhost:7168/Funciones/traerGeneros";
            var result = await Cliente.GetInstance().GetAsync(url);
            var generos = JsonConvert.DeserializeObject<List<Genero>>(result);

            cboGenero.DataSource = generos;
            cboGenero.ValueMember = "Id";
            cboGenero.DisplayMember = "Descripcion";
        }

        private async void AsyncCargarSalas()
        {
            string url = "https://localhost:7168/Funciones/traerSalas";
            var result = await Cliente.GetInstance().GetAsync(url);
            var salas = JsonConvert.DeserializeObject<List<Sala>>(result);

            cboSala.DataSource = salas;
            cboSala.ValueMember = "Id";
            cboSala.DisplayMember = "Descripcion";
        }

        public FrmFuncion(Funcion f)
        {
            InitializeComponent();

            dao = new FuncionDao();
            funcion = f;
            editar = true;
            btnInsert.Text = "Editar";


            txtTitulo.Text = f.Pelicula.Titulo;
            dtpFecha.Value = f.Fecha;
            dtpInicio.Value = f.HorarioInicio;
            dtpFin.Value = f.HorarioFin;
            dgvPelis.Rows.Add(new object[] {f.Pelicula.Id,f.Pelicula.Titulo,f.Pelicula.Genero.Descripcion,f.Pelicula.Duracion,
                    f.Pelicula.Director.ToString(),f.Pelicula.FechaEstreno.ToShortDateString(),f.Pelicula.Clasificacion.EdadMinima,f.Pelicula.Productora.Nombre});


            AsyncCargarGeneros();
            AsyncCargarSalas();
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

            pelis = dao.GetPeliculas(txtTitulo.Text, DateTime.MinValue, int.Parse(cboGenero.SelectedValue.ToString()));
            dgvPelis.Rows.Clear();
            foreach (Pelicula p in pelis)
            {
                dgvPelis.Rows.Add(new object[] {p.Id,p.Titulo,p.Genero.Descripcion,p.Duracion,
                    p.Director.ToString(),p.FechaEstreno.ToShortDateString(),p.Clasificacion.EdadMinima,p.Productora.Nombre});
            }

            if (dgvPelis.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró película con los parámetros ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private async void AsyncBtnBuscar_Click(object sender, EventArgs e)
        {

        }



        private async void btnInsert_Click(object sender, EventArgs e)
        {
            //validar Datos
            if (dtpInicio.Value >= dtpFin.Value)
            {
                MessageBox.Show("El horario de inicio debe ser menor al horario de salida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dtpFecha.Value < DateTime.Now || dtpFecha.Value == DateTime.Now && dtpInicio.Value < DateTime.Now)
            {
                MessageBox.Show("No se puede crear una función en el pasado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvPelis.CurrentRow == null)
            {
                MessageBox.Show("Debe elegir una película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //datos validados uwu
            if (!editar)
            {
                Funcion ff = new Funcion();
                ff.Sala = (Sala)cboSala.SelectedItem;
                ff.HorarioInicio = dtpInicio.Value;
                ff.HorarioFin = dtpFin.Value;
                foreach (Pelicula p in pelis)
                {
                    if (p.Id == Convert.ToInt32(dgvPelis.CurrentRow.Cells["colId"].Value))
                    {
                        ff.Pelicula = p;
                        break;
                    }
                }
                ff.Fecha = dtpFecha.Value;
                funcion = ff;
                //if (dao.Crear(ff))
                //{
                //    MessageBox.Show("Se creo la funcion con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("No se puedo crear la funcion :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

                await GuardarFuncionAsync();
            }
            else
            {
                Funcion ff = funcion;
                ff.Sala = (Sala)cboSala.SelectedItem;
                ff.HorarioInicio = dtpInicio.Value;
                ff.HorarioFin = dtpFin.Value;
                pelis = dao.GetPeliculas(txtTitulo.Text, DateTime.MinValue, int.Parse(cboGenero.SelectedValue.ToString()));
                foreach (Pelicula p in pelis)
                {
                    if (p.Id == Convert.ToInt32(dgvPelis.CurrentRow.Cells["colId"].Value))
                    {
                        ff.Pelicula = p;
                        break;
                    }
                }
                ff.Fecha = dtpFecha.Value;
                if (dao.Actualizar(ff))
                {
                    MessageBox.Show("Se Edito la funcion con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puedo Editar la funcion :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task GuardarFuncionAsync()
        {
            string bodyContent = JsonConvert.SerializeObject(funcion);
            string url = "https://localhost:7168/Funciones/cargar";
            var result = await Cliente.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Función registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            //    if (!activo) { ActivarHorarios(); }

            //    dtpInicio.MinDate = dtpFecha.Value.Date;
            //    dtpFin.MinDate = dtpFecha.Value.Date;

            //    dtpInicio.MaxDate = dtpFecha.Value.Date.AddDays(1).AddSeconds(-1);
            //    dtpFin.MaxDate = dtpFecha.Value.Date.AddDays(1).AddSeconds(-1);

        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cboSala.SelectedIndex = funcion.Sala.Tipo.Id - 1;

        }

        private async void FrmFuncion_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
