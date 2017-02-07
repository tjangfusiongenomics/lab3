using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3Application.Startup))]
namespace Lab3Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
