using CineBackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Datos.Interfaz
{
    public interface IFuncionDao
    {
        List<Funcion> GetFunciones(DateTime fecha);

        List<Pelicula> Peliculas( string titulo, DateTime estreno, int genero);

        List<Genero> GetGeneros();
        List<Sala> GetSalas();        
        bool Crear(Funcion f);
        bool Borrar(Funcion f);
        bool Actualizar(Funcion f);
    }
}
