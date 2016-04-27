using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week13_MVCDemo_04042016.Startup))]
namespace Week13_MVCDemo_04042016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
