using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Datos.Implementacion
{
    internal class ComprobanteDao : IComprobanteDao
    {
        public bool Actualizar(Comprobante c)
        {
            List<SqlParameter> sp = new List<SqlParameter>();
            
            throw new NotImplementedException();
        }

        public bool Borrar(Comprobante c)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Comprobante c)
        {
            throw new NotImplementedException();
        }

        public List<Comprobante> GetComprobantes()
        {
            throw new NotImplementedException();
        }

        public List <FormaPago > GetFormasDePago() {

            throw new NotImplementedException();
        }

        public List<Descuento> GetDescuentos()
        {

            throw new NotImplementedException();
        }

      
    }
}
