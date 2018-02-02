using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspMVC_ATM.Startup))]
namespace AspMVC_ATM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
