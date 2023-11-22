using CineBackEnd.Datos.Implementacion;
using CineBackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CineBackEnd.Datos.Interfaz
{
    public interface IPeliculaDao
    {
        List<Pelicula> GetPeliculas(string titulo , int Id_genero ,int AñoEstreno);
        
        bool Crear(Pelicula p);
        bool Actualizar(Pelicula p);
        bool BorrarPelicula(int id);
        Pelicula PeliculaXID(int id);
        DataTable PeliculasReporte(int seleccion);

    }
}
