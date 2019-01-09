using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GPay.Startup))]
namespace GPay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
