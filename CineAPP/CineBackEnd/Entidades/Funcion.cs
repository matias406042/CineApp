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
            Butacas = CrearButacas();
        }
        public List<Butaca> CrearButacas()
        {
            List<Butaca> butacas = new List<Butaca>();
            char fila = 'A';
            for (int i = 0; i < 5; i++)
            {
                int columna = 1;
                for (int j = 0; j < 7; j++)
                {
                    butacas.Add(new Butaca(fila, columna));
                    columna++;
                }
                fila = (char)((int)fila + 1);
            }
            return butacas;
        }
    }
}
