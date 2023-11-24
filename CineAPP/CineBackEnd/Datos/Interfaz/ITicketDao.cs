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
        List<Butaca> GetButacasXFuncion(int id_Funciom);

        List<Ticket> GetTicketsXComprobante(int idComprobante);

        Ticket TicketXID(int idTicket);
    }
}
