using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class Comprobante
    {
        public int Id { get; set; }

        public Descuento Descuento { get; set; }
        public FormaPago FormaPAgo { get; set; }
       
        public List <Ticket> Tickets { get; set; }
        public Comprobante()
        {
            Descuento = new Descuento();
            Tickets = new List<Ticket>();
            FormaPAgo = new FormaPago();
            
        }

        public void AgregarTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
        public double Total()
        {
            double aux = 0;    

            foreach (Ticket t in Tickets)
            {
                aux += t.Funcion.Precio;
            }
            return aux;
        }
    }
}
