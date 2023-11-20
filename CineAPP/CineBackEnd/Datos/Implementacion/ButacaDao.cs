using CineBackEnd.Datos.Interfaz;
using CineBackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Datos.Implementacion
{
    internal class ButacaDao : IButacaDao
    {
        private static ButacaDao instance;

        

        public  static ButacaDao ObtenerInstancia()
        {
            if (instance == null)
                instance = new ButacaDao();
            return instance;
        }

        public List<Butaca> ObtenerButacasXFuncion(int id_funcion)
        {
            string sp = "SP_Buscar_Butacas";

            List<SqlParameter> prms = new List<SqlParameter>();
            prms.Add(new SqlParameter("@IdFuncion", id_funcion));
            DataTable dt = new DataTable();
            dt= HelperDB.ObtenerInstancia().ConsultaSQL(sp,prms);
            List<Butaca> butacas = new List<Butaca>();
            foreach (DataRow f in dt.Rows)
            {
                Butaca butaca = new Butaca();
                butaca.Id = Convert.ToInt32(f[0]);
                butaca.Estado = Convert.ToString(f[2]);
                butaca.Fila = Convert.ToString(f[3]);
                butaca.Columna = Convert.ToInt32(f[4]);
                


                butacas.Add(butaca);
            }

            return butacas;
        }

        public Butaca ButacaXID(int idButaca)
        {
            throw new NotImplementedException();
        }
    }
}
