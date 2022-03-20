using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppJokes.Startup))]
namespace WebAppJokes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
