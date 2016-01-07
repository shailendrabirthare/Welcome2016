using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Welcome2016.Startup))]
namespace Welcome2016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
