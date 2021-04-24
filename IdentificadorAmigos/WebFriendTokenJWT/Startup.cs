using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFriendTokenJWT.Startup))]
namespace WebFriendTokenJWT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
