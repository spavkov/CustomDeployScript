using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspIdentityTest.Startup))]
namespace AspIdentityTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
