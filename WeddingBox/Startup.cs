using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeddingBox.Startup))]
namespace WeddingBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
