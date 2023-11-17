using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class SalaTipo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public SalaTipo()
        {
            
        }
        public SalaTipo(int id, string tipo)
        {
            Id = id;
            Descripcion = tipo;
        }
    }
}
