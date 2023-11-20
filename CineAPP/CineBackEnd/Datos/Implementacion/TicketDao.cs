using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace CineBackEnd.Datos.Implementacion
{
    public class TicketDao : ITicketDao
    {
        public bool Actualizar(Ticket t)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(Ticket t)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Ticket t)
        {
            throw new NotImplementedException();
        }

        public List<Butaca> GetButacaList()
        {
            throw new NotImplementedException();
        }

        public List<Pelicula> GetTickets()
        {
            throw new NotImplementedException();
        }
        
    }
}
