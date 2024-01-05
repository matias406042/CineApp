﻿using CineBackEnd.Datos;
using CineBackEnd.Entidades;
using CineBackEnd.Fachada.Implementacion;
using CineBackEnd.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cineController : ControllerBase
    {

        private IAplicacion app;
        public cineController()
        {
            app = new Aplicacion();
        }



        [HttpPut("/Usuario/loguear")]
        public IActionResult PutLogin(Usuarios credenciales)
        {
            try
            {
                bool aux = app.UsuarioLoguear(credenciales);
               return Ok(aux);
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno");
            }
        }
    
     
        [HttpGet("/Peliculas/traerXID")]

        public IActionResult GetPeliculaxID(int id_pelicula)
        {
            Pelicula peli = null;
            try
            {
                peli = app.PeliculaXID(id_pelicula);
                return Ok(peli);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }


        }


        [HttpPost("/Peliculas/cargar")]
        public IActionResult PostPelicula(Pelicula oPelicula)
        {
            try
            {
                if (oPelicula == null)
                    return BadRequest("pelicula inválida!!!");
                return Ok(app.SavePelicula(oPelicula));
                 
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }


        [HttpGet("/Peliculas/traer")]
        public IActionResult GetPeliculasParametro(string titulo, int id_genero, int anioEstreno)
        {
            try
            {
                List<Pelicula> lst = app.GetPeliculas(titulo,id_genero ,anioEstreno);
                if (lst != null)
                    return Ok(lst);
                else
                    return NotFound("peliculas no encontradas");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPut("/Peliculas/actualizar")]
        public IActionResult UpdatePelicula(Pelicula oPelicula)
        {
            try
            {

              
                    return Ok(app.UpdatePelicula(oPelicula));
                
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpDelete("/Peliculas/borrar")]
        public IActionResult Delete(int id)
        {
            try
            {
                
                    return Ok(app.DeletePelicula(id));
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }

        }

       
        [HttpGet("/Butacas/traer{id}")]
        public IActionResult GetButacas( int id_funcion)
        {
            try
            {
                List<Butaca> lst = app.GetButacasXFuncion(id_funcion);
                if (lst != null)
                    return Ok(lst);
                else
                    return NotFound("butacas no encontradas");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPut("/Butaca/desocupar")]
        public IActionResult PutButacaDesocupar(Ticket t)
        {
            try
            {

                if (app.OcuparButaca(false,t.Funcion.Id,t.Butaca.Fila,t.Butaca.Columna)>0)
                    return Ok("se actualizo la butaca con exito");
                else
                    return NotFound("NO se encontrado la butaca: ");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPut("/Butaca/ocupar")]
        public IActionResult PutButacaOcupar(Ticket t)
        {
            try
            {
                if(t != null)
                {
                    return Ok(app.OcuparButaca(true, t.Funcion.Id, t.Butaca.Fila, t.Butaca.Columna)); 
                }
                //if (app.OcuparButaca(true, t.Funcion.Id, t.Butaca.Fila, t.Butaca.Columna) > 0)
                //    return Ok("se actualizo la butaca con exito");
                else
                    return NotFound("NO se encontrado la butaca: ");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
      

        [HttpGet("/Funciones/traerFunciones")]
        public IActionResult GetFunciones(DateTime fecha, string titulo = null)
        {
            try
            {
                List<Funcion> lst = app.GetFunciones(fecha, titulo);
                if (lst != null)
                    return Ok(lst);
                else
                    return NotFound("funciones no encontradas");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/Funciones/traerPeliculas")]
        public IActionResult GetPeliculasF(string titulo, DateTime estreno, int genero)
        {
            try
            {
                List<Pelicula> lst = app.GetPeliculasX3Condiciones(titulo,estreno,genero);
                if (lst != null)
                    return Ok(lst);
                else
                    return NotFound("peliculas no encontradas");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("/Funciones/traerSalas")]
        public IActionResult GetSalas()
        {
            try
            {
                List<Sala> lst = app.GetSalas();
                if (lst != null)
                    return Ok(lst);
                else
                    return NotFound("salas no encontradas");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }

        }
        [HttpGet("/Funciones/traerGeneros")]
        public IActionResult GetGeneros()
        {
            try
            {
                List<Genero> lst = app.GetGeneros();
                if (lst != null)
                    return Ok(lst);
                else
                    return NotFound("generos no encontrados");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPost("/Funciones/cargar")]
        public IActionResult PostFuncion(Funcion oFuncion)
        {
            try
            {
                if (oFuncion == null)
                    return BadRequest("Funcion inválida!!!");
                return Ok(app.SaveFuncion(oFuncion));
          
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }

        }
        [HttpPut("/Funciones/act")]
        public IActionResult ActualizarFuncion(Funcion f)
        {
            try
            {

                return Ok(app.UpdateFuncion(f));
                
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpDelete("/Funciones/borrar")]
        public IActionResult DeleteFuncion(int id)
        {
            try
            {
                    return Ok(app.DeleteFuncion(id));
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }

        }

        //////// comprobantes 

        [HttpGet("/comprobantes")]
        public IActionResult GetComprobante(DateTime desde, DateTime hasta)
        {
            DataTable dt = null;
            try
            {
                dt = app.GetComprobantes(desde, hasta);
                var data = dt.AsEnumerable()
           .Select(row => dt.Columns.Cast<DataColumn>()
               .ToDictionary(col => col.ColumnName, col => row[col]))
           .ToList();

                return Ok(data);
                //return Ok(dt);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                //return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("/PeliculasRep")]

        public IActionResult GetPeliculasReporte(int selec)
        {
            DataTable dt = null;
            try
            {
                dt = app.GetPeliculasReporte(selec);
                var data = dt.AsEnumerable()
           .Select(row => dt.Columns.Cast<DataColumn>()
               .ToDictionary(col => col.ColumnName, col => row[col]))
           .ToList();

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);  
            }
        }

        [HttpGet("/comprobantes/FormasPago")]
        public IActionResult GetFormasPagos()
        {
            List<FormaPago> lst = null;
            try
            {
                lst = app.GetFormasDePago();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("/comprobantes/getDescuentos")]
        public IActionResult GetDescuentos()
        {
            List<Descuento> lst = null;
            try
            {
                lst = app.GetDescuentos();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        //// POST api/<ComprobanteController>
        [HttpPost("/comprobante/save")]
        public IActionResult PostComprobante(Comprobante comprobante)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                if (comprobante == null)
                    return BadRequest("Comprobante Invalido!");
                else { 
                return Ok(app.SaveComprobante(comprobante));
                }
                //else}
                //    return NotFound("No se pudo guardar el comprobante");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error Interno!, Intente luego...");
            }

        }

        [HttpPut("/comprobantes/act")]
        public IActionResult ActualizarComprobante(Comprobante ocomprobante)
        {
            try
            {

                if (app.UpdateComprobante(ocomprobante))
                    return Ok("se actualizo la butaca con exito");
                else
                    return NotFound("NO se encontradola butaca: ");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        //[HttpDelete("/Comprobantes/borrar{id}")]
        //public IActionResult DeleteComprobante(Comprobante ocomprobante)
        //{
        //    try
        //    {
        //        if (app.da(ocomprobante))
        //            return Ok("se borro exitosamente");
        //        else
        //            return NotFound("No se pudo borrar la butaca!!!");
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, "Error interno!!! Intente luego...");
        //    }

        //}
        //////tickets

        [HttpGet("/comprobantes/getTickets")]
        public IActionResult GetTicketsX(int id_comprobante)
        {
            List<Ticket> lst = null;
            try
            {
                lst = app.GetTicketsXComprobante(id_comprobante);
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
       

        [HttpGet("/Peliculas/traerProductora")]
        public IActionResult GetProductora()
        {
            List<Productora> lst = null;
            try
            {
                lst = app.GetProductora();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }

        }

        [HttpGet("/Peliculas/traerClasificaciones")]
        public IActionResult GetClasificaciones()
        {
            List<ClasificacionPelicula> lst = null;
            try
            {
                lst = app.GetClasificaciones();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }

        }
        

        [HttpGet("/Peliculas/traerGeneros")]
        public IActionResult GetGenerosP()
        {
            try
            {
                List<Genero> lst = app.GetGeneros();
                if (lst != null)
                    return Ok(lst);
                else
                    return NotFound("generos no encontrados");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}

