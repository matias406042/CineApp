using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class Ticket
    {
        public int Id { get; set; }

        public Funcion Funcion { get; set; }

        public Butaca Butaca { get; set; }

        public double Precio { get; set; }

        public Ticket()
        {
            Funcion = new Funcion();
            Butaca = new Butaca();
            
        }
    }
}
