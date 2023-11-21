using CineBackEnd.Datos;
using CineBackEnd.Entidades;
using CineBackEnd.Fachada.Implementacion;
using CineBackEnd.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetPelicula(int id)
        {
            Pelicula peli = null;
            try
            {
                peli = app.GetPelicula(id);
                return Ok(peli);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }


        }


        [HttpPost("/Peliculas/cargar")]
        public IActionResult PostPresupuesto(Pelicula oPelicula)
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
        public IActionResult GetPeliculasParametro(string titulo, int id, int estreno)
        {
            try
            {
                List<Pelicula> lst = app.GetPeliculaParametro(titulo, id, estreno);
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

        [HttpPut("/Peliculas/act")]
        public IActionResult ActPresupuesto(Pelicula oPelicula)
        {
            try
            {

                if (app.ActPelicula(oPelicula))
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

        [HttpPost("/butacas/cargar")]
        public IActionResult PostButaca(Butaca oButaca)
        {
            try
            {
                if (oButaca == null)
                    return BadRequest("butaca inválida!!!");
                if (app.saveButaca(oButaca))
                    return Ok(oButaca);
                else
                    return NotFound("No se pudo guardar la butaca!!!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }

        }
        [HttpGet("/Butacas/traer{id}")]
        public IActionResult GetButacas(string titulo, int id, int estreno)
        {
            try
            {
                List<Butaca> lst = app.GetButacas_Funcion(id);
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
        public IActionResult ActualizarButaca(Butaca obutaca)
        {
            try
            {

                if (app.ActButaca(obutaca))
                    return Ok("se actualizo la butaca con exito");
                else
                    return NotFound("NO se encontradola butaca: ");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpDelete("/Butacas/borrar{id}")]
        public IActionResult DeleteButaca(int id)
        {
            try
            {
                if (app.DeleteButaca(id))
                    return Ok("se borro exitosamente");
                else
                    return NotFound("No se pudo borrar la butaca!!!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }

        }
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
                List<Pelicula> lst = app.Peliculas(titulo,estreno,genero);
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
                if (app.saveFuncion(oFuncion))
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

                if (app.ActFuncion(f))
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
        public IActionResult GetComprobante()
        {
            List<Comprobante> lst = null;
            try
            {
                lst = app.GetComprobantes();
                return Ok(lst);

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

                if (app.ActComprobante(ocomprobante))
                    return Ok("se actualizo la butaca con exito");
                else
                    return NotFound("NO se encontradola butaca: ");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpDelete("/Comprobantes/borrar{id}")]
        public IActionResult DeleteComprobante(Comprobante ocomprobante)
        {
            try
            {
                if (app.deleteComprobante(ocomprobante))
                    return Ok("se borro exitosamente");
                else
                    return NotFound("No se pudo borrar la butaca!!!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }

        }
        //////tickets

        [HttpGet("/tickets")]
        public IActionResult GetTickets()
        {
            List<Pelicula> lst = null;
            try
            {
                lst = app.GetTickets();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("/tickets/getButacas")]
        public IActionResult getGetButacaT()
        {
            List<Butaca> lst = null;
            try
            {
                lst = app.GetButacaT();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpPost("/tickets")]
        public IActionResult PostTickets(Ticket ticket)
        {
            try
            {
                if (ticket == null)
                    return BadRequest("Ticket Invalido!");
                if (app.SaveTicket(ticket))
                    return Ok(ticket);
                else
                    return NotFound("No se pudo guardar el ticket");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error Interno!, Intente luego...");
            }
        }

        [HttpPut("/tickets")]
        public IActionResult PutTicket(Ticket ticket)
        {
            try
            {

                if (app.ActTicket(ticket))
                    return Ok("se actualizo el ticket con exito");
                else
                    return NotFound("NO se encontrado el ticket: ");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }

        }

        [HttpDelete("/tickets/{id}")]
        public IActionResult DeleteTickets(Ticket oTicket)
        {
            try
            {
                if (app.DeleteTicket(oTicket))
                    return Ok("se borro exitosamente");
                else
                    return NotFound("No se pudo borrar el ticket!!!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }
    }
}

