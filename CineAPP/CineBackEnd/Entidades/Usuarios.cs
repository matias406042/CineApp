using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class Usuarios
    {
        public string User { get; set; }
        public string Contra { get; set; }
        public int Credencial { get; set; }
        public Usuarios(string user, string contra)
        {
            User = user;
            Contra = contra;
            
        }
    }
}
