using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineBackEnd.Entidades;

namespace CineBackEnd.Datos.Interfaz
{
    public interface IUsuarioDao
    {
        public List<Usuarios> GetUsuarios();
    }
}
