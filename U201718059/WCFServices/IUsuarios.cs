using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServices.Dominio;

namespace WCFServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuarios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuarios
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Usuarios", ResponseFormat = WebMessageFormat.Json)]
        Usuario CrearUsuario(Usuario usuarioACrear);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Usuarios/{dni}", ResponseFormat = WebMessageFormat.Json)]
        Usuario ObtenerUsuario(string dni);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Usuarios", ResponseFormat = WebMessageFormat.Json)]
        Usuario ModificarUsuario(Usuario usuarioAModificar);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Usuarios/{dni}", ResponseFormat = WebMessageFormat.Json)]
        Usuario EliminarUsuario(string dni);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Usuarios", ResponseFormat = WebMessageFormat.Json)]
        List<Usuario> ListarUsuarios();

    }
}
