using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class Sala
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public int Capacidad { get; set; }
        public SalaTipo Tipo { get; set; }

        public Sala() { Tipo = new SalaTipo(); }
        public Sala(int id,string descripcion,int capacidad, SalaTipo tipo)
        {
            Id = id;
            Descripcion = descripcion;
            Capacidad = capacidad;
            Tipo = tipo;
        }
        public override string ToString()
        {
            return Tipo.Descripcion;
        }
    }
}
