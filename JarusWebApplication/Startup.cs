using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JarusWebApplication.Startup))]
namespace JarusWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
