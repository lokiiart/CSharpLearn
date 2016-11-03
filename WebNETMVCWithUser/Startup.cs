using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebNETMVCWithUser.Startup))]
namespace WebNETMVCWithUser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
