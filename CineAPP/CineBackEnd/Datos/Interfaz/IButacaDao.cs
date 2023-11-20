using CineBackEnd.Datos.Implementacion;
using CineBackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Datos.Interfaz
{
    internal interface IButacaDao
    {

        List<Butaca> ObtenerButacasXFuncion(int ID_funcion);

        Butaca ButacaXID(int idButaca);
    }
}
