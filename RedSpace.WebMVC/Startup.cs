using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedSpace.WebMVC.Startup))]
namespace RedSpace.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
