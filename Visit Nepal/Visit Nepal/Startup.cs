using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Visit_Nepal.Startup))]
namespace Visit_Nepal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
