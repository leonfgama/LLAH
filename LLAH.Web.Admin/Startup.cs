using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LLAH.Web.Admin.Startup))]
namespace LLAH.Web.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
