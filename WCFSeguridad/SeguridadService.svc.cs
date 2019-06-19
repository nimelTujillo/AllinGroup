using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFSeguridad.Dominio;
using WCFSeguridad.Persistencia;

namespace WCFSeguridad
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SeguridadService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SeguridadService.svc o SeguridadService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SeguridadService : ISeguridadService
    {
        public Usuario Autenticacion(string usu_login, string pass_login)
        {
            var usuarioDAO = new UsuarioDAO();
            return usuarioDAO.Autenticacion(usu_login, pass_login);
        }
    }
}
