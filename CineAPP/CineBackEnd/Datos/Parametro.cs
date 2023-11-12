using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Datos
{
    public class Parametro
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public Parametro() { }

        public Parametro(string n , object v) { 
        
            this.Name = n;
            this.Value = v;
        }
    }
}
