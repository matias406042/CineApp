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
    public class UsuarioDao : IUsuarioDao
    {
        public List<Usuarios> GetUsuarios()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            string sp = "SP_GET_USUARIOS";
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL(sp, new List<SqlParameter>());
            foreach (DataRow f in dt.Rows)
            {
                usuarios.Add(new Usuarios(f[1].ToString(), f[2].ToString()));
            }
            return usuarios;
        }
    }
}
