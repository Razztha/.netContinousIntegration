using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestIntegrattion.Startup))]
namespace TestIntegrattion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
