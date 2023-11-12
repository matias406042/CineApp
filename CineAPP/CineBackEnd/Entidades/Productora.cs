using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class Productora
    {

        public int Id { get; set; }

        public string Nombre { get; set; }
        
        public Pais Pais { get; set; }
        public Productora()
        {
                Pais = new Pais();
        }
    }
}
