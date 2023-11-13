using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CineBackEnd.Datos.Implementacion
{
    internal class FuncionDao : IFuncionDao
    {
        public bool Actualizar(Funcion f)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Funcion f)
        {
            //List<> list = null;
            throw new NotImplementedException();
        }

        public List<Genero> GetGeneros()
        {
            throw new NotImplementedException();
        }

        public List<Sala> GetSalas()
        {
            throw new NotImplementedException();
        }

        public List<Funcion> GetFunciones(DateTime fecha)
        {
            List<Funcion> lstFunciones = new List<Funcion>();
            string sp = "SP_Funciones_Fecha";
            List<Parametro> listParametros = new List<Parametro>();
            listParametros.Add(new Parametro("@fecha", fecha));
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, listParametros);
            foreach (DataRow fila in tabla.Rows)
            {
                Funcion f = new Funcion();
                f.Pelicula = new Pelicula(fila["TITULO"].ToString(), fila["GENERO"].ToString());
                f.Sala = new Sala(fila["SALA"].ToString());
                f.HorarioInicio = DateTime.Parse(fila["HORARIO_INICIO"].ToString());
                f.HorarioFin = DateTime.Parse(fila["HORARIO_FIN"].ToString());
                f.Fecha = fecha;
                lstFunciones.Add(f);
            }
            return lstFunciones;
        }  

        public List<Pelicula> Peliculas()
        {
            throw new NotImplementedException();
        }
    }
}
