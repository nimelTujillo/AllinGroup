using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFSeguridad.Dominio;

namespace WCFSeguridad
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISeguridadService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISeguridadService
    {
        [OperationContract]
        Usuario Autenticacion(string usu_login, string pass_login);
    }
}
