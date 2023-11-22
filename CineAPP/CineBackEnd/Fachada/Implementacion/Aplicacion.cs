using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Entidades;
using CineBackEnd.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        IFuncionDao daoFuncion;
        IPeliculaDao daoPelicula;
        ITicketDao daoTicket;
        IComprobanteDao daoComprobante;
        
      

        public bool DeleteFuncion(Funcion f)
        {
            return daoFuncion.Borrar(f); 
        }

        public bool DeletePelicula(int id)
        {
            return daoPelicula.BorrarPelicula(id);
        }

        public List<Butaca> GetButacasXFuncion(int id_Funciom)
        {
          return daoTicket.GetButacasXFuncion(id_Funciom);
        }

        public List<Butaca> GetButacasXFuncion(Funcion f)
        {
            return daoFuncion.BuscarButacas(f);
        }

        public List<Comprobante> GetComprobantes(DateTime desde ,DateTime hasta)
        {
            return daoComprobante.GetComprobantes(desde, hasta);
        }

        public List<Descuento> GetDescuentos()
        {
           return daoComprobante.GetDescuentos();
        }

        public List<FormaPago> GetFormasDePago()
        {
            return daoComprobante.GetFormasDePago();
        }

        public List<Funcion> GetFunciones(DateTime fecha, string titulo)
        {
            return daoFuncion.GetFunciones(fecha, titulo);
        }

        public List<Genero> GetGeneros()
        {
            return daoFuncion.GetGeneros();
        }

        public List<Pelicula> GetPeliculas(string titulo, int Id_genero, int AñoEstreno)
        {
            return daoPelicula.GetPeliculas(titulo, Id_genero, AñoEstreno);
        }

        public List<Pelicula> GetPeliculasX3Condiciones(string titulo, DateTime estreno, int genero)
        {
           return daoFuncion.GetPeliculas(titulo, estreno, genero);
        }

        public List<Sala> GetSalas()
        {
           return daoFuncion.GetSalas();
        }

        public List<Ticket> GetTicketsXComprobante(int idComprobante)
        {
           return daoTicket.GetTicketsXComprobante(idComprobante);
        }

        public Ticket GetTicketXID(int idTicket)
        {
           return daoTicket.TicketXID(idTicket);
        }

        public int OcuparButaca(bool ocupar, int id_funcion, string fila, int columna)
        {
            return daoFuncion.OcuparButaca(ocupar, id_funcion, fila, columna);
        }

        public Pelicula PeliculaXID(int id)
        {
            return daoPelicula.PeliculaXID(id);
        }

        public bool SaveComprobante(Comprobante c)
        {
            return daoComprobante.Crear(c);
        }

        public bool SaveFuncion(Funcion f)
        {
           return daoFuncion.Crear(f);
        }

        public bool SavePelicula(Pelicula p)
        {
           return daoPelicula.Crear(p);
        }

        public bool UpdateComprobante(Comprobante c)
        {
            return UpdateComprobante(c);
        }

        public bool UpdateFuncion(Funcion f)
        {
           return daoFuncion.Actualizar(f);
        }

        public bool UpdatePelicula(Pelicula p)
        {
            return daoPelicula.Actualizar(p);
        }
    }
}
