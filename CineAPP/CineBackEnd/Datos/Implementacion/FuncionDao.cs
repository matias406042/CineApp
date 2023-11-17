using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CineBackEnd.Datos.Implementacion
{
    public class FuncionDao : IFuncionDao
    {
        public bool Actualizar(Funcion f, Pelicula p, Sala s, TimeOnly desde, TimeOnly hasta, DateTime fecha)
        {
            string sp = "SP_UPDATE_FUNCION";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id_funcion", f.Id));
            parametros.Add(new SqlParameter("@id_pelicula", p.Id));
            parametros.Add(new SqlParameter("@id_sala", s.Id));
            parametros.Add(new SqlParameter("@horario_inicio", desde));
            parametros.Add(new SqlParameter("@horario_fin", hasta));
            parametros.Add(new SqlParameter("@fecha", fecha));
            if (HelperDB.ObtenerInstancia().SPTransaccionSimpleSQL(sp, parametros) <= 0)
                return false;
            else
                return true;
        }
        public bool Borrar(int id)
        {
            string sp = "SP_BORRAR_FUNCION";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id_funcion",id));
            if(HelperDB.ObtenerInstancia().SPTransaccionSimpleSQL(sp,parametros) <= 0)
                return false;
            else
                return true;

        }

        public bool Crear(Funcion f)
        {
            string sp = "SP_CREAR_FUNCION";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id_funcion",f.Id));
            parametros.Add(new SqlParameter("@id_pelicula",f.Pelicula.Id));
            parametros.Add(new SqlParameter("@id_sala",f.Sala.Id));
            parametros.Add(new SqlParameter("@horario_inicio", f.HorarioInicio));
            parametros.Add(new SqlParameter("@horario_fin", f.HorarioFin));
            parametros.Add(new SqlParameter("@fecha", f.Fecha));
            if(HelperDB.ObtenerInstancia().SPTransaccionSimpleSQL(sp,parametros) <= 0)
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
            string sp = "SP_GET_SALAS";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);
            foreach (DataRow fila in tabla.Rows)
            {
                Sala s = new Sala();
                s.Descripcion = fila["Sala"].ToString();
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
            string sp = "SP_GET_FUNCIONES";
            List<SqlParameter> listParametros = new List<SqlParameter>();
            listParametros.Add(new SqlParameter("@fecha", fecha));
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, listParametros);
            foreach (DataRow fila in tabla.Rows)
            {   
                Genero g = new Genero();
                    g.Id = int.Parse(fila["Id_Genero"].ToString());
                    g.Descripcion = fila["Genero"].ToString();
                Productora prod = new Productora();
                    prod.Id = int.Parse(fila["Id_Productora"].ToString());
                    prod.Nombre = fila["Productora"].ToString();
                    prod.Pais = new Pais(int.Parse(fila["Id_Pais_Productora"].ToString()), fila["Pais_Productora"].ToString());
                ClasificacionPelicula c = new ClasificacionPelicula();
                    c.Id = int.Parse(fila["Id_Clasificacion"].ToString());
                    c.EdadMinima = int.Parse(fila["Edad_Clasf"].ToString());
                Director d = new Director();
                    d.ID = int.Parse(fila["Id_Director"].ToString());
                    d.Nombre = fila["Nombre_Dir"].ToString();
                    d.Apellido = fila["Ape_Dir"].ToString();
                    d.Edad = int.Parse(fila["Edad_Dir"].ToString());
                    d.Nacionalidad = new Pais(int.Parse(fila["Id_Pais_Dir"].ToString()), fila["Pais_Director"].ToString());
                Pelicula p = new Pelicula();
                    p.Id = int.Parse(fila["Id_Pelicula"].ToString());
                    p.Titulo = fila["Titulo"].ToString();
                    p.Duracion = int.Parse(fila["Duracion"].ToString());
                    p.FechaEstreno = DateTime.Parse(fila["Fecha_Estreno"].ToString());
                    p.Genero = g;
                    p.Clasificacion = c;
                    p.Director = d;
                    p.Productora = prod;
                SalaTipo st = new SalaTipo(int.Parse(fila["Id_Tipo_Sala"].ToString()), fila["Tipo_Sala"].ToString());
                Funcion f = new Funcion();
                    f.Pelicula = p;
                    f.Sala = new Sala(int.Parse(fila["Id_Sala"].ToString()), fila["Sala"].ToString(), int.Parse(fila["Capacidad"].ToString()), st);
                    f.HorarioInicio = TimeOnly.Parse(fila["Inicio"].ToString());
                    f.HorarioFin = TimeOnly.Parse(fila["Fin"].ToString());
                    f.Fecha = fecha;
                lstFunciones.Add(f);
            }
            return lstFunciones;
        }  

        public List<Pelicula> Peliculas(string titulo, DateTime estreno, int genero)
        {
            List<Pelicula> lstPeliculas = new List<Pelicula>();
            string sp = "SP_BUSCAR_PELICULAS";
            List<SqlParameter> parametros = new List<SqlParameter>();
            if (titulo != null)
                parametros.Add(new SqlParameter("@titulo", titulo));
            else
                parametros.Add(new SqlParameter("@titulo", null));
            if (estreno != DateTime.MinValue)
                parametros.Add(new SqlParameter("@AñoEstreno", estreno.Year));
            else
                parametros.Add(new SqlParameter("@AñoEstreno", null));
            if (genero != -1)
                parametros.Add(new SqlParameter("@id_genero", genero));
            else
                parametros.Add(new SqlParameter("@id_genero", null));
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);
            foreach (DataRow fila in tabla.Rows)
            {
                
                Genero g = new Genero();
                    g.Id = int.Parse(fila["GeneroID"].ToString());
                    g.Descripcion = fila["GeneroDescripcion"].ToString();
                Productora prod = new Productora();
                    prod.Id = int.Parse(fila["ProductoraID"].ToString());
                    prod.Nombre = fila["ProductoraNombre"].ToString();
                ClasificacionPelicula c = new ClasificacionPelicula();
                    c.Id = int.Parse(fila["CalificacionID"].ToString());
                    c.EdadMinima = int.Parse(fila["CalificacionEdad"].ToString());
                Pelicula p = new Pelicula();
                    p.Id = int.Parse(fila["PeliculasID"].ToString());
                    p.Titulo = fila["PeliculaTitulo"].ToString();
                    p.Duracion = int.Parse(fila["PeliculaDuracion"].ToString());
                    p.FechaEstreno = DateTime.Parse(fila["PeliculaEstreno"].ToString()); 
                    p.Genero = g;
                    p.Clasificacion = c;                
                    p.Productora = prod;
                lstPeliculas.Add(p);
            }
            return lstPeliculas ;
        }
    }
}
