using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControleUsuario.Web.Startup))]
namespace ControleUsuario.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
