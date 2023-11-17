using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class Funcion
    {
        public int Id { get; set; }

        public Pelicula Pelicula { get; set; }

        public Sala Sala { get; set; }

        public int Precio { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime HorarioInicio{ get; set; }

        public DateTime HorarioFin   { get; set; }

        public List <Butaca> Butacas { get; set; }

        public Funcion()
        {
            Pelicula = new Pelicula();
            Butacas = new List<Butaca>();
        }

    }
}
