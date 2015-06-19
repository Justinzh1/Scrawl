using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scrawl.Startup))]
namespace Scrawl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
