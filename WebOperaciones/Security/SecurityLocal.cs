
namespace WebOperaciones.Security
{
    using System;
    using System.Web;
    using WCFSeguridad.Dominio;

    public class SecurityLocal
    { 
        public static Usuario Usuario
        {
            get
            {
                try
                {
                    var inst = System.Web.HttpContext.Current.Session["SessionUsuario"];
                    if (inst == null)
                    {
                        HttpContext.Current.Response.StatusCode = 401;
                        return new Usuario() { email = string.Empty };
                    }
                    else
                        return System.Web.HttpContext.Current.Session["SessionUsuario"] as Usuario;
                }
                catch (Exception)
                {
                    HttpContext.Current.Response.StatusCode = 401;
                    throw;
                }
            }
        }
        
        public static bool IsAuthenticated
        {
            get
            {
                return Convert.ToBoolean(HttpContext.Current.Session["SessionIsAuthenticated"]);
            }
        }
         
        public static void SignOut()
        {
            HttpContext.Current.Session["SessionUsuario"] = null;
            HttpContext.Current.Session["SessionIsAuthenticated"] = false;
        }
    }
}
