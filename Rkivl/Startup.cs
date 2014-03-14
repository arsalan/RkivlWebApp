using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rkivl.Startup))]
namespace Rkivl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
