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
        public bool Actualizar(Funcion f, Pelicula p, Sala s, DateTime desde, DateTime hasta, DateTime fecha)
        {
            string sp = "SP_UPDATE_FUNCION";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id_funcion", f.Id));
            parametros.Add(new Parametro("@id_pelicula", p.Id));
            parametros.Add(new Parametro("@id_sala", s.Id));
            parametros.Add(new Parametro("@horario_inicio", desde));
            parametros.Add(new Parametro("@horario_fin", hasta));
            parametros.Add(new Parametro("@fecha", fecha));
            if (HelperDB.ObtenerInstancia().SPSimpleSQL(sp, parametros) <= 0)
                return false;
            else
                return true;
        }
        public bool Borrar(int id)
        {
            string sp = "SP_BORRAR_FUNCION";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id_funcion",id));
            if(HelperDB.ObtenerInstancia().SPSimpleSQL(sp,parametros) <= 0)
                return false;
            else
                return true;

        }

        public bool Crear(Funcion f)
        {
            string sp = "SP_CREAR_FUNCION";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id_funcion",f.Id));
            parametros.Add(new Parametro("@id_pelicula",f.Pelicula.Id));
            parametros.Add(new Parametro("@id_sala",f.Sala.Id));
            parametros.Add(new Parametro("@horario_inicio", f.HorarioInicio));
            parametros.Add(new Parametro("@horario_fin", f.HorarioFin));
            parametros.Add(new Parametro("@fecha", f.Fecha));
            if(HelperDB.ObtenerInstancia().SPSimpleSQL(sp,parametros) <= 0)
                return false;
            else
                return true;
        }

        public List<Genero> GetGeneros()
        {
            List<Genero> lstGeneros = new List<Genero>();
            string sp = "SP_GET_GENEROS";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);
            foreach (DataRow fila in tabla.Rows)
            {
                Genero g = new Genero(fila["genero"].ToString());
                g.Id = Convert.ToInt32(fila["id_genero"]);
                lstGeneros.Add(g);
            }
            return lstGeneros;
        }

        public List<Sala> GetSalas()
        {
            List<Sala> lstSalas = new List<Sala>();
            string sp = "SP_GET_GENEROS";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);
            foreach (DataRow fila in tabla.Rows)
            {
                Sala s = new Sala(fila["Sala"].ToString());
                s.Id = Convert.ToInt32(fila["id_Sala"]);
                s.Tipo = new SalaTipo(Convert.ToInt32(fila["id_Tipo"]), fila["Tipo"].ToString());
                s.Capacidad = Convert.ToInt32(fila["Capacidad"]);
                lstSalas.Add(s);
            }
            return lstSalas;
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
            List<Pelicula> lstPeliculas = new List<Pelicula>();
            string sp = "SP_BUSCAR_PELICULAS";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@titulo", null));
            parametros.Add(new Parametro("@AñoEstreno", null));
            parametros.Add(new Parametro("@id_genero", null));
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);
            foreach (DataRow fila in tabla.Rows)
            {
                Pelicula p = new Pelicula();
                Genero g = new Genero();
                Productora prod = new Productora();
                ClasificacionPelicula c = new ClasificacionPelicula();
                p.Id = int.Parse(fila["PeliculasID"].ToString());
                p.Titulo = fila["PeliculaTitulo"].ToString();
                p.Duracion = int.Parse(fila["PeliculaDuracion"].ToString());
                p.FechaEstreno = DateTime.Parse(fila["PeliculaEstreno"].ToString());
                g.Id = int.Parse(fila["GeneroID"].ToString());
                g.Descripcion = fila["GeneroDescripcion"].ToString();
                p.Genero = g;
                c.Id = int.Parse(fila["CalificacionID"].ToString()); 
                c.EdadMinima = int.Parse(fila["CalificacionEdad"].ToString());
                p.Clasificacion = c;
                prod.Id = int.Parse(fila["ProductoraID"].ToString());
                prod.Nombre = fila["ProductoraNombre"].ToString();
                p.Productora = prod;
                lstPeliculas.Add(p);
            }
            return lstPeliculas ;
        }
    }
}
