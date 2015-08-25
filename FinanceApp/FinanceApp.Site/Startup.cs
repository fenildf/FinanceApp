using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinanceApp.Site.Startup))]
namespace FinanceApp.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
