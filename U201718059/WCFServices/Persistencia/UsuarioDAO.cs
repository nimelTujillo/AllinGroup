using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFServices.Dominio;

namespace WCFServices.Persistencia
{
    public class UsuarioDAO
    {
        private string CadenaConexion = "Data Source=DESKTOP-VEOBI30; Initial Catalog = BD_Operaciones; Integrated Security=SSPI;";

        public Usuario Crear(Usuario usuarioACrear)
        {
            Usuario usuarioCreado = null;
            string sentencia = "INSERT INTO usuario VALUES(@dni, @nom, @apell, @email, @usu, @pass, @est)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@dni", usuarioACrear.Dni));
                    comando.Parameters.Add(new SqlParameter("@nom", usuarioACrear.Nombre));
                    comando.Parameters.Add(new SqlParameter("@apell", usuarioACrear.Apelllido));
                    comando.Parameters.Add(new SqlParameter("@email", usuarioACrear.Email));
                    comando.Parameters.Add(new SqlParameter("@usu", usuarioACrear.UsuLogin));
                    comando.Parameters.Add(new SqlParameter("@pass", usuarioACrear.ContraLogin));
                    comando.Parameters.Add(new SqlParameter("@est", usuarioACrear.Estado));
                    comando.ExecuteNonQuery();
                }
            }
            usuarioCreado = Obtener(usuarioCreado.Dni);
           return usuarioCreado;
        }
        public Usuario Obtener(int dni)
        {
            Usuario usuarioEncontrado = null;
            string sentencia = "SELECT * FROM usuario WHERE dni_usuario = @dni";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@dni", dni));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if(resultado.Read())
                        {
                            usuarioEncontrado = new Usuario()
                            {
                                Dni = (int)resultado["dni_usuario"],
                                Nombre = (string)resultado["nombre"],
                                Apelllido = (string)resultado["apellido"],
                                Email = (string)resultado["email"],
                                UsuLogin = (string)resultado["usu_login"],
                                ContraLogin = (string)resultado["pass_login"],
                                Estado = (string)resultado["tx_estado"]
                            };
                        }
                    }
                }
            }
            return usuarioEncontrado;
        }
        public Usuario Modificar(Usuario usuarioAModificar)
        {
            Usuario usuarioModificado = null;
            string sentencia = "UPDATE usuario SET nombre = @nom, apellido = @apell,email =  @email, usu_login = @usu, pass_login = @pass, tx_estado = @est WHERE dni = @dni";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nom", usuarioAModificar.Nombre));
                    comando.Parameters.Add(new SqlParameter("@apell", usuarioAModificar.Apelllido));
                    comando.Parameters.Add(new SqlParameter("@email", usuarioAModificar.Email));
                    comando.Parameters.Add(new SqlParameter("@usu", usuarioAModificar.UsuLogin));
                    comando.Parameters.Add(new SqlParameter("@pass", usuarioAModificar.ContraLogin));
                    comando.Parameters.Add(new SqlParameter("@est", usuarioAModificar.Estado));
                    comando.ExecuteNonQuery();
                }
            }
            usuarioModificado = Obtener(usuarioAModificar.Dni);
            return usuarioModificado;
        }
        public Usuario Eliminar(int dni)
        {
            string sentencia = "DELETE FROM usuario WHERE dni = @dni";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@dni", dni));
                    comando.ExecuteNonQuery();
                }
            }
            return null;
        }
        public List<Usuario> Listar()
        {
            List<Usuario> usuariosEcontrados = new List<Usuario>();
            Usuario usuarioEncontrado = null;
            string sentencia = "SELECT * FROM usuario";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            usuarioEncontrado = new Usuario()
                            {
                                Dni = (int)resultado["dni_usuario"],
                                Nombre = (string)resultado["nombre"],
                                Apelllido = (string)resultado["apellido"],
                                Email = (string)resultado["email"],
                                UsuLogin = (string)resultado["usu_login"],
                                ContraLogin = (string)resultado["pass_login"],
                                Estado = (string)resultado["tx_estado"]
                            };
                            usuariosEcontrados.Add(usuarioEncontrado);
                        }
                    }

                }

            }
            return usuariosEcontrados;
        }
    }
}