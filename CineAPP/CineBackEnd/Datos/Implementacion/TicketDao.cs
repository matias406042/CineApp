using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace CineBackEnd.Datos.Implementacion
{
    public class TicketDao : ITicketDao
    {
        
        public List<Butaca> GetButacasXFuncion(int id_Funciom)
        {
            return ButacaDao.ObtenerInstancia().ObtenerButacasXFuncion(id_Funciom);
        }

        

        public List<Ticket> GetTicketsXComprobante(int idComprobante)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Id_Comprobante", idComprobante));
            DataTable dataTable = HelperDB.ObtenerInstancia().ConsultaSQL("SP_TICKETS_X_COMPROBANTE", parameters);


            List<Ticket> tickets = new List<Ticket>();
            foreach (DataRow f in dataTable.Rows)
            {
               int idTicket= Convert.ToInt32(f["id_ticket"]);
                Ticket t = TicketXID(idTicket);
                tickets.Add(t);
            }
            return tickets;
        }

        public Ticket TicketXID(int idTicket)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdTicket", idTicket));
            DataTable dataTable = HelperDB.ObtenerInstancia().ConsultaSQL("SP_TICKET_X_ID", parameters);
            Ticket t = new Ticket();
            foreach (DataRow f in dataTable.Rows)
            {
                

                t.Id = Convert.ToInt32(f["id_ticket"]);
                t.Precio = Convert.ToDouble(f["pre_unit"]);


                int idFuncion = Convert.ToInt32(f["id_funcion"]);
                t.Funcion = FuncionDao.ObtenerInstancia().FuncionXID(idFuncion);


                int idButaca = Convert.ToInt32(f["id_butaca"]);
                t.Butaca = ButacaDao.ObtenerInstancia().ButacaXID(idButaca);

            }

            return t;

        }

    }
}
