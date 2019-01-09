using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GPay.Admin.Startup))]
namespace GPay.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
