using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EIPWebApplicationWilliam1.Startup))]
namespace EIPWebApplicationWilliam1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
