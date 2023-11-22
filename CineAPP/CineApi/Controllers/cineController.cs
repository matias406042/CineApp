using CineBackEnd.Datos;
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


        // GET: api/<cineController>
        [HttpGet]
        [HttpGet("/Peliculas/traer{id}")]
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
                if (app.SavePelicula(oPelicula))
                    return Ok(oPelicula);
                else
                    return NotFound("No se pudo guardar la pelicula!!!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
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

                if (app.UpdatePelicula(oPelicula))
                    return Ok("se actualizo la pelicula con exito");
                else
                    return NotFound("NO se encontradola pelicula: ");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpDelete("/Peliculas/borrar{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (app.DeletePelicula(id))
                    return Ok("se borro exitosamente");
                else
                    return NotFound("No se pudo borrar la pelicula!!!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }

        }
        /////////////////////////////////////////////////
        /// butacas 

        //[HttpPost("/butacas/cargar")]
        //public IActionResult PostButaca(Butaca oButaca)
        //{
        //    try
        //    {
        //        if (oButaca == null)
        //            return BadRequest("butaca inválida!!!");
        //        if (app.saveButaca(oButaca))
        //            return Ok(oButaca);
        //        else
        //            return NotFound("No se pudo guardar la butaca!!!");
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, "Error interno!!! Intente luego...");
        //    }

        //}
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

        [HttpPut("/Butaca/act")]
        public IActionResult ActualizarButaca(bool ocupar,int id_funcion,string fila,int columna)
        {
            try
            {

                if (app.OcuparButaca(ocupar,id_funcion,fila,columna)>0)
                    return Ok("se actualizo la butaca con exito");
                else
                    return NotFound("NO se encontradola butaca: ");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        //[HttpDelete("/Butacas/borrar{id}")]
        //public IActionResult DeleteButaca(int id)
        //{
        //    try
        //    {
        //        if (app.DeleteButaca(id))
        //            return Ok("se borro exitosamente");
        //        else
        //            return NotFound("No se pudo borrar la butaca!!!");
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, "Error interno!!! Intente luego...");
        //    }

        //}
        ///////////////////////////
        ////

        [HttpGet("/Funciones/traerFunciones")]
        public IActionResult GetFunciones(DateTime fecha, string titulo)
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
                if (app.SaveFuncion(oFuncion))
                    return Ok(oFuncion);
                else
                    return NotFound("No se pudo guardar la Funcion!!!");
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

                if (app.UpdateFuncion(f))
                    return Ok("se actualizo la funcion con exito");
                else
                    return NotFound("NO se encontradola funcion");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpDelete("/Funciones/borrar{id}")]
        public IActionResult DeleteFuncion(Funcion f)
        {
            try
            {
                if (app.DeleteFuncion(f))
                    return Ok("se borro exitosamente");
                else
                    return NotFound("No se pudo borrar la funcion!!!");
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
                return Ok(dt);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
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
        [HttpPost("/comprobantes")]
        public IActionResult PostComprobante(Comprobante comprobante)
        {
            try
            {
                if (comprobante == null)
                    return BadRequest("Comprobante Invalido!");
                if (app.SaveComprobante(comprobante))
                    return Ok(comprobante);
                else
                    return NotFound("No se pudo guardar el comprobante");
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
                List<Genero> lst = app.GetGenerosP();
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

