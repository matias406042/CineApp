using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class Butaca
    {
        public int Id{ get; set; }
       public string Estado { get; set; }

        public int Fila  { get; set;}

        public int Columna { get; set; }

        public Butaca()
        {
            
        }



    }
}
