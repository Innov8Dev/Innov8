using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Innov8.Startup))]
namespace Innov8
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
