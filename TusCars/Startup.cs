using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TusCars.Startup))]
namespace TusCars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
