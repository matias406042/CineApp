using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineBackEnd.Entidades;
using System.Data;

namespace CineBackEnd.Fachada.Interfaz
{
    public interface IAplicacion
    {
        public bool DeleteFuncion(Funcion f);

        public bool DeletePelicula(int id);


        public List<Butaca> GetButacasXFuncion(int id_Funciom);


        public List<Butaca> GetButacasXFuncion(Funcion f);


        public DataTable GetComprobantes(DateTime desde, DateTime hasta);


        public List<Descuento> GetDescuentos();


        public List<FormaPago> GetFormasDePago();


        public List<Funcion> GetFunciones(DateTime fecha, string titulo);


        public List<Genero> GetGeneros();


        public List<Pelicula> GetPeliculas(string titulo, int Id_genero, int AñoEstreno);


        public List<Pelicula> GetPeliculasX3Condiciones(string titulo, DateTime estreno, int genero);


        public List<Sala> GetSalas();


        public List<Ticket> GetTicketsXComprobante(int idComprobante);


        public Ticket GetTicketXID(int idTicket);


        public int OcuparButaca(bool ocupar, int id_funcion, string fila, int columna);


        public Pelicula PeliculaXID(int id);


        public bool SaveComprobante(Comprobante c);

        public bool SaveFuncion(Funcion f);


        public bool SavePelicula(Pelicula p);


        public bool UpdateComprobante(Comprobante c);


        public bool UpdateFuncion(Funcion f);


        public bool UpdatePelicula(Pelicula p);

        public List<Productora> GetProductora();

        public List<ClasificacionPelicula> GetClasificaciones();

        public List<Genero> GetGenerosP();
        public DataTable GetPeliculasReporte(int selec);

    }
}
