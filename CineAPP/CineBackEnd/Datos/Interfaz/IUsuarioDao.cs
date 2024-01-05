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
        List<Usuarios> GetUsuarios();

        bool ConectarUsuario(Usuarios u);
    }
}
