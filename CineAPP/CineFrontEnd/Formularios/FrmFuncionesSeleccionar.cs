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

namespace CineFrontEnd.Formularios
{
    public partial class FrmFuncionesSeleccionar : Form
    {
        int id = -1;
        IFuncionDao funcionDao;
        List<Funcion> listaFunciones;
        public FrmFuncionesSeleccionar()
        {
            InitializeComponent();
            funcionDao = new FuncionDao();
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
            listaFunciones = funcionDao.GetFunciones(dtpFecha.Value,string.Empty);
            dgvFunciones.Rows.Clear();
            foreach (Funcion f in listaFunciones)
            {
                dgvFunciones.Rows.Add(new object[] {f.Id,f.Pelicula.Titulo,f.Pelicula.Genero.Descripcion,f.HorarioInicio,f.HorarioFin,f.Sala.Descripcion });
            }
            if (dgvFunciones.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado películas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Funcion ff = new Funcion();
            if( listaFunciones == null || listaFunciones.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar una función", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (Funcion fun in listaFunciones)
            {
                if(fun.Id == Convert.ToInt32(dgvFunciones.CurrentRow.Cells["colIdFuncion"].Value)) 
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
                if (funcionDao.Borrar(ff))
                {
                    MessageBox.Show("Se elimino la funcion con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la funcion :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eliminacion cancelada","Cancelar",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
           
        }
    }
}
