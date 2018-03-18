using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NovaServer.UI.Startup))]
namespace NovaServer.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
