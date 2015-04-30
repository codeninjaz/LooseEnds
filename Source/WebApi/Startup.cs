using Microsoft.Owin;
using Owin;
using WebApi;

[assembly: OwinStartup(typeof(Startup))]

namespace WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
