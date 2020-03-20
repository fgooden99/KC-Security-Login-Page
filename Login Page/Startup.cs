using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Login_Page.Startup))]
namespace Login_Page
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
