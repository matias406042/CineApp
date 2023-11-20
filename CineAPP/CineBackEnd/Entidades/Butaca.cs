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

        public string Fila  { get; set;}

        public int Columna { get; set; }

        public Butaca()
        {
            
        }
        public override string ToString()
        {
            return $"{Fila}{Columna}";
        }
        public Butaca(char fila, int columna)
        {
            Fila = fila.ToString();
            Columna = columna;
            Estado = "Disponible";
        }
        public Butaca(string fila, int columna, string estado)
        {
            Fila = fila;
            Columna = columna;
            Estado = estado;
        }

    }
}
