using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Entidades;
using CineBackEnd.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CineBackEnd.Datos.Implementacion
{
    public class ComprobanteDao : IComprobanteDao
    {
        public bool Actualizar(Comprobante c)
        {
            //List<SqlParameter> sp = new List<SqlParameter>();
            
            throw new NotImplementedException();
        }

        public bool Borrar(Comprobante c)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Comprobante c)
        {
            string spMaestro = "SP_ADD_COMPROBANTE";
            string spDetalle = "SP_ADD_TICKET";
            List<SqlParameter> paramsMaestro = new List<SqlParameter>();
                paramsMaestro.Add(new SqlParameter("@id_pago", c.FormaPAgo.Id));
                paramsMaestro.Add(new SqlParameter("@total", c.Total));
                if(c.Descuento.Id != 0)
                    paramsMaestro.Add(new SqlParameter("@id_descuento", c.Descuento.Id));
                else 
                    paramsMaestro.Add(new SqlParameter("@id_descuento", DBNull.Value));
                SqlParameter p = new SqlParameter("@id_compr", SqlDbType.Int);
                p.Direction = ParameterDirection.Output;
                paramsMaestro.Add(p);
            List<SqlParameter> paramsDetalle = new List<SqlParameter>();
            foreach (Ticket t in c.Tickets)
            {
                paramsDetalle.Add(new SqlParameter("@id_funcion", t.Funcion.Id));
                //paramsDetalle.Add(new SqlParameter("@id_butaca"))
            }
            return HelperDB.ObtenerInstancia().SPMaestroDetalle(paramsMaestro, paramsDetalle, spMaestro, spDetalle, "@id_comprobante");

        }

        public List<Comprobante> GetComprobantes()
        {
            throw new NotImplementedException();
        }

        public List <FormaPago > GetFormasDePago() {

            List<FormaPago> formasPago = new List<FormaPago>();
            string sp = "SP_GET_FORMA_PAGO";
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);
            foreach (DataRow fila in dt.Rows)
            {
                formasPago.Add(new FormaPago(Convert.ToInt32(fila[0].ToString()), fila[1].ToString()));
            }
            return formasPago;
        }

        public List<Descuento> GetDescuentos()
        {
            List<Descuento> descuentos = new List<Descuento>();
            string sp = "SP_GET_DESCUENTOS";
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);
            foreach (DataRow fila in dt.Rows)
            {
                descuentos.Add(new Descuento(Convert.ToInt32(fila[0]), fila[1].ToString(), Convert.ToDouble(fila[2].ToString())));
            }
            return descuentos;
        }

        public DataTable GetComprobantes(DateTime desde, DateTime hasta)
        {
            string sp = "SP_REPORTE_COMPROBANTES";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@desde", desde));
            parametros.Add(new SqlParameter("@hasta", hasta));
            return HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);
        }
    }
}
