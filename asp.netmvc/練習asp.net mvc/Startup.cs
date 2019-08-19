using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(練習asp.net_mvc.Startup))]
namespace 練習asp.net_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
