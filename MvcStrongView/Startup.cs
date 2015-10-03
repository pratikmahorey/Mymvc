using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcStrongView.Startup))]
namespace MvcStrongView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
