using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NavigationActiveTest.Startup))]
namespace NavigationActiveTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
