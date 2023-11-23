using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class ClasificacionPelicula
    {
        public int Id { get; set; }

        public int EdadMinima { get; set; }


        public ClasificacionPelicula(int edad)
        {
            EdadMinima = edad;
        }
        public ClasificacionPelicula()
        {
            
        }

    }
}
