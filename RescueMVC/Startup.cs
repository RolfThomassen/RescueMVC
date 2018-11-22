using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RescueMVC.Startup))]
namespace RescueMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
