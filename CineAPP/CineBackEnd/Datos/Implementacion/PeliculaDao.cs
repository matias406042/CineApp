using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Datos.Implementacion
{
    internal class PeliculaDao : IPeliculaDao
    {
        public bool Actualizar(Pelicula p)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Pelicula p)
        {
           List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdGenero", p.Genero.Id));
            parameters.Add(new SqlParameter("@IdClasificacion",p.Clasificacion.Id));
            parameters.Add(new SqlParameter("@IdProductora", p.Productora.Id));
            parameters.Add(new SqlParameter("@IdDirecto", p.Director.ID));

            if (HelperDB.ObtenerInstancia().SPTransaccionSimpleSQL("SP_Insertar_Peliculas", parameters) <= 0)
            {
                return false;
            }
            else return true;
           ;
        }

        public Pelicula PeliculaXID(int id) 
        {

            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add( new SqlParameter("@id", id));

            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL("SP_PELICULIA_X_ID", prms);
            Pelicula p = new Pelicula();
            foreach (DataRow f in dt.Rows)
            {
                
                p.Id = Convert.ToInt32(f[0]);
                p.Titulo = Convert.ToString(f[1]);
                p.Duracion = Convert.ToInt32(f[2]);
                p.FechaEstreno = Convert.ToDateTime(f[3]);
                p.Genero.Id = Convert.ToInt32(f[4]);
                p.Genero.Descripcion = Convert.ToString(f[5]);
                p.Clasificacion.Id = Convert.ToInt32(f[6]);
                p.Clasificacion.EdadMinima = Convert.ToInt32(f[7]);
                p.Productora.Id = Convert.ToInt32(f[8]);
                p.Productora.Nombre = Convert.ToString(f[9]);
                

            }
            return p;
          
        }

        public List<Pelicula> GetPeliculas(string titulo, int Id_genero, int AñoEstreno)
        {
           List<SqlParameter> prms = new List<SqlParameter>();
            
            SqlParameter p0 = new SqlParameter("@Titulo",titulo);
            SqlParameter p1 = new SqlParameter("@id_Genero", Id_genero);
            SqlParameter p2 = new SqlParameter("@AñoEstreno",AñoEstreno);

            prms.Add(p0); prms.Add(p1);prms.Add(p2);

            string sp = "SP_BUSCAR_PELICULAS";
           DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, prms);

            List<Pelicula> peliculas = new List<Pelicula>();

            foreach (DataRow r in tabla.Rows)
            {
                Pelicula p = new Pelicula();
                p.Id = Convert.ToInt32( r[0]);
                p.Titulo = Convert.ToString(r[1]);
                p.Duracion = Convert.ToInt32(r[2]);
                p.FechaEstreno = Convert.ToDateTime(r[3]);
                p.Genero.Id = Convert.ToInt32(r[4]);
                p.Genero.Descripcion = Convert.ToString(r[5]);
                p.Clasificacion.Id = Convert.ToInt32(r[6]);
                p.Clasificacion.EdadMinima = Convert.ToInt32(r[7]);
                p.Productora.Id = Convert.ToInt32(r[8]);
                p.Productora.Nombre = Convert.ToString(r[9]);
                peliculas.Add(p);

            }

            return peliculas;






        }


    }
}
