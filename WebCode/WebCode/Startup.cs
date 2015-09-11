using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCode.Startup))]
namespace WebCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
