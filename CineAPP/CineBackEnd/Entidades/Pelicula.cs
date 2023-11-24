using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class Pelicula
    {

        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime FechaEstreno { get; set; }

        public int Duracion { get; set; }

        public Genero Genero { get; set; }

        public ClasificacionPelicula Clasificacion { get; set; }    

        public Productora Productora { get; set; }

        public Director Director { get; set; }
        public List<Actores> Reparto { get; set; }

        public Pelicula()
        {
            Genero = new Genero();
            Clasificacion = new ClasificacionPelicula();
            Productora = new Productora();        
            Reparto = new List<Actores>();
            Director = new Director();
            Titulo = string.Empty;
            FechaEstreno = DateTime.Now;
            Duracion = 0; 
            Id = 0; 
        }

    }
}
