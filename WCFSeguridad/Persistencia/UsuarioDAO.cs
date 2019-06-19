using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFSeguridad.Dominio;

namespace WCFSeguridad.Persistencia
{
    public class UsuarioDAO
    {
        private string CadenaConexion = "Data Source=.; Initial Catalog=BDOperaciones; Integrated Security=SSPI;";
        public Usuario Autenticacion(string usu_login, string pass_login)
        {
            Usuario Encontrado = null;
            string sql = "SELECT * FROM dbo.Usuario WHERE usu_login = @usu_login";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@usu_login", usu_login ?? ""));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            if (resultado["pass_login"].ToString() == pass_login)
                            {
                                Encontrado = new Usuario()
                                {
                                    dni_usuario = (int)resultado["dni_usuario"],
                                    nombre = (string)resultado["nombre"],
                                    apellido = (string)resultado["apellido"],
                                    email = (string)resultado["email"],
                                    usu_login = (string)resultado["usu_login"],
                                    pass_login = (string)resultado["pass_login"],
                                    tx_estado = (string)resultado["tx_estado"]
                                };
                            }
                        }
                    }
                }
            }
            return Encontrado;
        }

    }
}