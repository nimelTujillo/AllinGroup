using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebOperaciones.Startup))]
namespace WebOperaciones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
