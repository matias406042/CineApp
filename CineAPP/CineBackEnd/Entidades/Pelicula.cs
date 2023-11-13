﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Entidades
{
    public class Pelicula
    {

        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime FechaEstreno { get; set; }

        public DateTime Duracion { get; set; }


        public Genero Genero { get; set; }

        public ClasificacionPelicula Clasificacion { get; set; }    

        public Productora Productora { get; set; }

        public List<Actores> Reparto { get; set; }


        public Pelicula()
        {
            Genero = new Genero();
            Clasificacion = new ClasificacionPelicula();
            Productora = new Productora();        
            Reparto = new List<Actores>();
        }
        public Pelicula(string titulo, string genero)
        {
            Genero = new Genero(genero);
            Titulo = titulo;
        }

    }
}
