using CineBackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Datos.Interfaz
{
    public interface ITicketDao
    {

        List<Pelicula> GetTickets();

        List<Butaca> GetButacaList();

        bool Crear(Ticket t);
        bool Actualizar(Ticket t);
        bool Borrar(Ticket t);



    }
}
