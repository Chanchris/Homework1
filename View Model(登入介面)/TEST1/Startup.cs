using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TEST1.Startup))]
namespace TEST1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
