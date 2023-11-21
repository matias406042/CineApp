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
        List<Pelicula> pelis;


        public FrmFuncion()
        {
            InitializeComponent();
            dao = new FuncionDao();
            editar = false;
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
            dao = new FuncionDao();
            funcion = f;
            editar = true;
            btnInsert.Text = "Editar";
            CargarGeneros();
            CargarSalas();
            cboSala.SelectedIndex = f.Sala.Id - 1;
            txtTitulo.Text = f.Pelicula.Titulo;
            dtpFecha.Value = f.Fecha;
            dtpInicio.Value = f.HorarioInicio;
            dtpFin.Value = f.HorarioFin;
            cboGenero.SelectedIndex = f.Pelicula.Genero.Id - 1;
            dgvPelis.Rows.Add(new object[] {f.Pelicula.Id,f.Pelicula.Titulo,f.Pelicula.Genero.Descripcion,f.Pelicula.Duracion,
                    f.Pelicula.Director.ToString(),f.Pelicula.FechaEstreno.ToShortDateString(),f.Pelicula.Clasificacion.EdadMinima,f.Pelicula.Productora.Nombre});
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
            pelis = dao.Peliculas(txtTitulo.Text, DateTime.MinValue, int.Parse(cboGenero.SelectedValue.ToString()));
            dgvPelis.Rows.Clear();
            foreach (Pelicula p in pelis)
            {
                dgvPelis.Rows.Add(new object[] {p.Id,p.Titulo,p.Genero.Descripcion,p.Duracion,
                    p.Director.ToString(),p.FechaEstreno.ToShortDateString(),p.Clasificacion.EdadMinima,p.Productora.Nombre});
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //validar Datos
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
                if (dao.Crear(ff))
                {
                    MessageBox.Show("Se creo la funcion con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puedo crear la funcion :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Funcion ff = funcion;
                ff.Sala = (Sala)cboSala.SelectedItem;
                ff.HorarioInicio = dtpInicio.Value;
                ff.HorarioFin = dtpFin.Value;
                pelis = dao.Peliculas(txtTitulo.Text, DateTime.MinValue, int.Parse(cboGenero.SelectedValue.ToString()));
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvPelis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
