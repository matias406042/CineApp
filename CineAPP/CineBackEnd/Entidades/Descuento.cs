using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class Descuento
    {
        public int Id { get; set; }

        public string  Motivo { get; set; }

        public double Porcentaje { get; set; }


        public Descuento()
        {
            
        }
        public Descuento(int id, string motivo, double porcentaje)
        {
            Id = id;
            Motivo = motivo;
            Porcentaje = porcentaje;
        }
        public override string ToString()
        {
            return $"{Porcentaje}%";
        }
    }
}
