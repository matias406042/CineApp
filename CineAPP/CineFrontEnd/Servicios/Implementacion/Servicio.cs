using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineFrontEnd.Servicios.Interfaz;
using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Datos.Implementacion;

namespace CineFrontEnd.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        ITicketDao dao;
        public Servicio()
        {
            dao = new TicketDao();
        }
    }
}
