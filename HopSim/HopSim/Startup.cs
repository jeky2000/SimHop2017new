using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HopSim.Startup))]
namespace HopSim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
