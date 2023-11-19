using CineBackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Datos.Interfaz
{
    public interface IComprobanteDao
    {
        List<Comprobante> GetComprobantes();   

        bool Crear(Comprobante c);
        bool Actualizar(Comprobante c);
        bool Borrar(Comprobante c);
        List<FormaPago> GetFormasDePago();
        List<Descuento> GetDescuentos();


       
    }
}
