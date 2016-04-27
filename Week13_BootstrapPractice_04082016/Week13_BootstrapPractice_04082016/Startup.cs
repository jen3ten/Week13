using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week13_BootstrapPractice_04082016.Startup))]
namespace Week13_BootstrapPractice_04082016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
