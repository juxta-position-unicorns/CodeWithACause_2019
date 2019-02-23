using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StlCollegePrepWebsite.Startup))]
namespace StlCollegePrepWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
