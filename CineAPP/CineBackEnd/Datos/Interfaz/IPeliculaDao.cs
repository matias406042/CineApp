using CineBackEnd.Datos.Implementacion;
using CineBackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Datos.Interfaz
{
    public interface IPeliculaDao
    {
        List<Pelicula> GetPeliculas(string titulo , int Id_genero ,int AñoEstreno);
       
        bool Crear(Pelicula p);
        bool Actualizar(Pelicula p);
        bool Borrar(int id);

    }
}
