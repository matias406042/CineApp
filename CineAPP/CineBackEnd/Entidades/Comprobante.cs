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
        public double Total { get; set; }
        public List <Ticket> Tickets { get; set; }
        public Comprobante()
        {
            Descuento = new Descuento();
            Tickets = new List<Ticket>();
            FormaPAgo = new FormaPago();
            Total = 0;
        }

        public void AgregarTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
        public void EliminarTicket(int index)
        {
            Tickets.RemoveAt(index);
        }

    }
}
