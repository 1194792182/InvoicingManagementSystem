using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yjj.Web.Startup))]
namespace Yjj.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
