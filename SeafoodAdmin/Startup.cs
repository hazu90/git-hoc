using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeafoodAdmin.Startup))]
namespace SeafoodAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
