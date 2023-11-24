using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CineBackEnd.Datos
{
     class HelperDB
    {
        private static HelperDB instancia;
        private SqlConnection cnn;

        private HelperDB()
        {
            cnn = new SqlConnection(Properties.Resources.conexionTomi);
        }

        public static HelperDB ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDB();
            return instancia;
        }
        public DataTable ConsultaSQL(string spNombre, List<SqlParameter> values)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (SqlParameter oParametro in values)
                {
                    if (oParametro.Value == null)
                        oParametro.Value = DBNull.Value;
                    cmd.Parameters.Add(oParametro);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

  
        

       

        public int SPTransaccionSimpleSQL(string strSql, List<SqlParameter> parametros)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSql;
                cmd.Transaction = t;

                if (parametros != null)
                {
                    foreach (SqlParameter param in parametros)
                    {
                        cmd.Parameters.Add(param);
                    }
                }

                afectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return afectadas;
        }

        public bool SPInsertMaestroDetalleSQL(List<SqlParameter> pMaestro, List<SqlParameter> pDetalle, string SPMaestro, string SPDetalle, string nameNroMaestro)//, string nameNroDet)
        {
            bool aux = true;
            SqlTransaction t = null;
            try
            {


                cnn.Open();
                t = cnn.BeginTransaction();



                SqlCommand comando = new SqlCommand(SPMaestro, cnn, t);
                comando.CommandType = CommandType.StoredProcedure;


                comando.Parameters.AddRange(pMaestro.ToArray());
                comando.ExecuteNonQuery();

                int nroMaestro = 0;
                foreach (SqlParameter p in pMaestro)
                {
                    if (p.Direction == ParameterDirection.Output)
                    {
                        nroMaestro = (int)p.Value;
                        break;
                    }

                }


                int nroDetalles = 0;
                SqlCommand cmdDetalles = new SqlCommand(SPDetalle, cnn, t);
                cmdDetalles.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter p in pDetalle)
                {
                    if (p == pDetalle[pDetalle.Count - 1])///Si es el ultimo detalle lo agrega junto a los predeterminados inserta y vacia los parametros del comando
                    {
                        cmdDetalles.Parameters.Add(p);
                        cmdDetalles.Parameters.AddWithValue(nameNroMaestro, nroMaestro);
                        //cmdDetalles.Parameters.AddWithValue(nameNroDet, nroDetalles);

                        cmdDetalles.ExecuteNonQuery();
                        cmdDetalles.Parameters.Clear();


                    }
                    else
                    {

                        bool repite = false;
                        foreach (SqlParameter pcmd in cmdDetalles.Parameters)/// verificamos si el parametro es de un nuevo detalle o no
                                                                             /// xq cada detalle no puede tener 2 parametros con el mismo nombre
                        {
                            if (p.ParameterName == pcmd.ParameterName)
                            {
                                repite = true;
                            }
                        }
                        if (repite)///si repite es por que es de un nuevo detalle => agregamos predeterminados ejecutamos y limpiamos comando
                                   /// acomodamos el nro del nuevodetalle y  agregamos este ultimo parametro al comando 
                        {

                            cmdDetalles.Parameters.AddWithValue(nameNroMaestro, nroMaestro);
                            //cmdDetalles.Parameters.AddWithValue(nameNroDet, nroDetalles);
                            cmdDetalles.ExecuteNonQuery();
                            cmdDetalles.Parameters.Clear();

                            nroDetalles++;
                            cmdDetalles.Parameters.Add(p);
                        }
                        else      /// si no se repite el parametro pertenese al mismo detalle => lo agregamos al cmd
                        {
                            cmdDetalles.Parameters.Add(p);
                        }



                    }
                }
                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                    aux = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return aux;

        }

        public bool SPMaestroDetalle(List<SqlParameter> pMaestro, List<List<SqlParameter>> pDetalles, string SPMaestro, string SPDetalle, string nameNROMaestro)
        {
            bool aux = true;
            SqlTransaction t = null;
            try
            {


                cnn.Open();
                t = cnn.BeginTransaction();



                SqlCommand comando = new SqlCommand(SPMaestro, cnn, t);
                comando.CommandType = CommandType.StoredProcedure;


                comando.Parameters.AddRange(pMaestro.ToArray());
                comando.ExecuteNonQuery();

                int nroMaestro = 0;
                foreach (SqlParameter p in pMaestro)
                {
                    if (p.Direction == ParameterDirection.Output)
                    {
                        nroMaestro = (int)p.Value;
                        break;
                    }

                }


                int nroDetalles = 0;
                SqlCommand cmdDetalles = new SqlCommand(SPDetalle, cnn, t);
                cmdDetalles.CommandType = CommandType.StoredProcedure;

                foreach (List<SqlParameter> lstp in pDetalles)
                {
                    cmdDetalles.Parameters.Clear();
                    foreach (SqlParameter pd in lstp)
                    {
                        cmdDetalles.Parameters.AddWithValue(nameNROMaestro, nroMaestro);
                        cmdDetalles.Parameters.Add(pd);
                    }
                    cmdDetalles.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                aux = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return aux;
        }


        public SqlConnection ObtenerConexion()
        {
            return this.cnn;
        }
     }

}

