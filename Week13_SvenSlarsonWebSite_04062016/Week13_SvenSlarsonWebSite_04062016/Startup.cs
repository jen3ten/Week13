using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week13_SvenSlarsonWebSite_04062016.Startup))]
namespace Week13_SvenSlarsonWebSite_04062016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
