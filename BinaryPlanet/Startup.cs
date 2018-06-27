using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BinaryPlanet.Startup))]
namespace BinaryPlanet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
