using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Flower.Web.Startup))]
namespace Flower.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
