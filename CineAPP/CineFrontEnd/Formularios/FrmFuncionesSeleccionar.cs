using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineBackEnd.Datos.Implementacion;
using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Entidades;
using CineFrontEnd.Http;
using Newtonsoft.Json;

namespace CineFrontEnd.Formularios
{
    public partial class FrmFuncionesSeleccionar : Form
    {
        int id = -1;
        IFuncionDao funcionDao;
        List<Funcion> listaFunciones;
        ITicketDao ticketDao;
        public FrmFuncionesSeleccionar()
        {
            InitializeComponent();
            funcionDao = new FuncionDao();
            ticketDao = new TicketDao();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmFuncionesSeleccionar_Load(object sender, EventArgs e)
        {

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {


                DialogResult = MessageBox.Show("¿Seguro desea Eliminar la funcion?");

                if (DialogResult == DialogResult.OK || DialogResult == DialogResult.Yes)
                {

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FrmFuncion f = new FrmFuncion();
            f.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            asyncBuscarFunciones();


            listaFunciones = funcionDao.GetFunciones(dtpFecha.Value,string.Empty);
            
        }

        private async void asyncBuscarFunciones()
        {
            string url = string.Format("https://localhost:7168/Funciones/traerFunciones?fecha={0}", DateTime.MinValue.ToString("yyyy-MM-dd"));
            var result = await Cliente.GetInstance().GetAsync(url);
            var funciones = JsonConvert.DeserializeObject<List<Funcion>>(result);


            listaFunciones = funcionDao.GetFunciones(dtpFecha.Value, string.Empty);

            dgvFunciones.Rows.Clear();
            foreach (Funcion f in listaFunciones)
            {
                dgvFunciones.Rows.Add(new object[] { f.Id, f.Pelicula.Titulo, f.Pelicula.Genero.Descripcion, f.HorarioInicio, f.HorarioFin, f.Sala.Descripcion });
            }

            if (dgvFunciones.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado funciones.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Funcion ff = new Funcion();
            if (listaFunciones == null || listaFunciones.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar una función", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (Funcion fun in listaFunciones)
            {
                if (fun.Id == Convert.ToInt32(dgvFunciones.CurrentRow.Cells["colIdFuncion"].Value))
                {
                    ff = fun;
                    break;
                }


            }
            FrmFuncion f = new FrmFuncion(ff);
            f.ShowDialog();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            if (listaFunciones == null || listaFunciones.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar una función", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Esta seguro de borrar esta funcion", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                Funcion ff = new Funcion();
                foreach (Funcion fun in listaFunciones)
                {
                    if (fun.Id == Convert.ToInt32(dgvFunciones.CurrentRow.Cells["colIdFuncion"].Value))
                    {
                        ff = fun;
                        break;
                    }
                }

                if(existeTicket(ff))
                {
                    MessageBox.Show("No se puede eliminar una función que haya vendido tickets.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                asyncBorrarFuncion(ff);


            }
            else
            {
                MessageBox.Show("Eliminacion cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void cambiarTextolbl(string texto)
        {

        }

        private void FrmFuncionesSeleccionar_Load_1(object sender, EventArgs e)
        {

        }

        private bool existeTicket(Funcion f)
        {
            bool existe = false;

            foreach (Ticket ticket in ticketDao.GetTicketPorFuncion(f.Id))
            {
                if(ticket.Funcion.Id == f.Id)
                {
                    existe = true;
                    break;
                }
                else { existe = false; }
            }

            return existe;
        }

        private async void asyncBorrarFuncion(Funcion ff)
        {
            string url = string.Format("https://localhost:7168/Funciones/borrar?id={0}", ff.Id);
            var result = await Cliente.GetInstance().DeleteAsync(url);
            var funcion = JsonConvert.DeserializeObject<bool>(result);

            if (funcion)
            {
                MessageBox.Show("Se elimino la funcion con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //soy muy bueno
            else
            {
                MessageBox.Show("No se puede eliminar una función que haya vendido tickets.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
