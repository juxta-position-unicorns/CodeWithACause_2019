using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeForACause.Startup))]
namespace CodeForACause
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
