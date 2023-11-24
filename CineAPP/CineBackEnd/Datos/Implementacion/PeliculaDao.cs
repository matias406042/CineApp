using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Datos.Implementacion
{
    public class PeliculaDao : IPeliculaDao
    {
        private static PeliculaDao instance;

        public static PeliculaDao ObtenerInstancia()
        {
            if (instance == null)
                instance = new PeliculaDao();
            return instance;
        }

        public bool Actualizar(Pelicula p)
        {
            List<SqlParameter>prms = new List<SqlParameter>();
            prms.Add(new SqlParameter("@Id", p.Id));
            prms.Add(new SqlParameter("@IdGenero", p.Genero.Id));
            prms.Add(new SqlParameter("@IdClasificacion",p.Clasificacion.Id));
            prms.Add(new SqlParameter("@IdProductora",p.Productora.Id));
            prms.Add(new SqlParameter("@Titulo", p.Titulo));
            prms.Add(new SqlParameter("@DuracionMinutos", p.Duracion));
            prms.Add(new SqlParameter("@Fecha", p.FechaEstreno.ToString("dd/MM/yyyy")));
            string sp = "SP_PELICULA_ACTUALIZAR";

            if (HelperDB.ObtenerInstancia().SPTransaccionSimpleSQL(sp, prms) > 0)
            {
                return true;
            }
            else return false;


        }

        public bool BorrarPelicula(int id)
        {
            string sp = "SP_PELICULA_DELETE";
            List<SqlParameter>prms =new List<SqlParameter>();
            prms.Add(new SqlParameter("@id", id));
            if(
            HelperDB.ObtenerInstancia().SPTransaccionSimpleSQL(sp, prms)>0
            )return true;
            else return false;

        }

        public bool Crear(Pelicula p)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdGenero", p.Genero.Id));
            parameters.Add(new SqlParameter("@IdClasificacion", p.Clasificacion.Id));
            parameters.Add(new SqlParameter("@IdProductora", p.Productora.Id));
            parameters.Add(new SqlParameter("@Titulo", p.Titulo));
            parameters.Add(new SqlParameter("@DuracionMinutos", p.Duracion));
            parameters.Add(new SqlParameter("@Fecha", p.FechaEstreno));

            if (HelperDB.ObtenerInstancia().SPTransaccionSimpleSQL("SP_Insertar_Pelicula", parameters) <= 0)
            {
                return false;
            }
            else return true;
           ;
        }

        public Pelicula PeliculaXID(int id) 
        {

            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add( new SqlParameter("@ID", id));

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
           
            if (titulo== "Nulo") { prms.Add(new SqlParameter("@Titulo", null)); }
            else { prms.Add(new SqlParameter("@Titulo", titulo)); }

            if (Id_genero == -1) { prms.Add(new SqlParameter("@id_Genero", null)); }
            else { prms.Add(new SqlParameter("@id_Genero", Id_genero)); }

            if(AñoEstreno == -1) { prms.Add( new SqlParameter("@AñoEstreno", null)); }
            else { prms.Add( new SqlParameter("@AñoEstreno", AñoEstreno)); }
           

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



        public List<Productora> GetProductora()
        {
            List<Productora> lstProductora = new List<Productora>();
            string sp = "SP_GET_PRODUCTORAS";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);
            foreach (DataRow fila in tabla.Rows)
            {
                Productora p = new Productora();
                p.Id = Convert.ToInt32(fila["id_productora"]);
                p.Nombre = Convert.ToString(fila["nombre"]);
                p.Pais.Id = Convert.ToInt32(fila["id_pais"]);
                p.Pais.Nombre = Convert.ToString(fila["pais"]);
                           

                      
                lstProductora.Add(p);
            }
            return lstProductora;
        }


        public List<ClasificacionPelicula> GetClasificacion()
        {
            List<ClasificacionPelicula> lstClasificacion = new List<ClasificacionPelicula>();
            string sp = "SP_GET_CLASIFICACIONES";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);
            foreach (DataRow fila in tabla.Rows)
            {
                ClasificacionPelicula p = new ClasificacionPelicula(Convert.ToInt32(fila["edad"]));
                p.Id = Convert.ToInt32(fila["id_clasificacion"]);
                lstClasificacion.Add(p);
            }
            return lstClasificacion;
        }



        public DataTable PeliculasReporte(int seleccion)
        {
            string sp = "SP_REPORTE_PELICULAS";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter("@seleccion", seleccion));
            return HelperDB.ObtenerInstancia().ConsultaSQL(sp, lst);
        }

    }
}
