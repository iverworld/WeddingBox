using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestIG.Startup))]
namespace TestIG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
