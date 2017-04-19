using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoTeste.Startup))]
namespace ProjetoTeste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
