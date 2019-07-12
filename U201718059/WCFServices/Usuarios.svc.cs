using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServices.Dominio;
using WCFServices.Errores;
using WCFServices.Persistencia;

namespace WCFServices
{

    public class Usuarios : IUsuarios
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        public Usuario CrearUsuario(Usuario usuarioACrear)
        {
            Usuario usuarioExistente = usuarioDAO.Obtener(usuarioACrear.Dni);
            if (usuarioExistente != null)
            {
                throw new WebFaultException<DuplicadoException>(new DuplicadoException()
                {
                    Codigo = 102,
                    Descripcion = "Usuario duplicado"
                }, HttpStatusCode.Conflict);
            }
            return usuarioDAO.Crear(usuarioACrear);
        }

        public Usuario EliminarUsuario(string dni)
        {
           return usuarioDAO.Eliminar(int.Parse(dni));
        }

        public List<Usuario> ListarUsuarios()
        {
            return usuarioDAO.Listar();
        }

        public Usuario ModificarUsuario(Usuario usuarioAModificar)
        {
            return usuarioDAO.Modificar(usuarioAModificar);
        }

        public Usuario ObtenerUsuario(string dni)
        {
            return usuarioDAO.Obtener(int.Parse(dni));
        }
    }
}
