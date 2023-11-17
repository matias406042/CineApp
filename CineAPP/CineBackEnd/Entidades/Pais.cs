using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class Pais
    {

        public int Id  { get; set; }
        public string Nombre { get; set; }

        public Pais()
        {
            
        }
        public Pais(int id, string pais)
        {
            Id = id;
            Nombre = pais;
        }
    }
}
