using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class FormaPago
    {

        public int Id { get; set; }
        public string Forma { get; set; }

        public FormaPago()
        {
            
        }
        public FormaPago(int id, string forma)
        {
            Id = id;
            Forma = forma;
        }
    }
}
