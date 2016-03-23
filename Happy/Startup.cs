using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Happy.Startup))]
namespace Happy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
