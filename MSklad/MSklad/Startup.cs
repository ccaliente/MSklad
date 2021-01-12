using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSklad.Startup))]
namespace MSklad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
