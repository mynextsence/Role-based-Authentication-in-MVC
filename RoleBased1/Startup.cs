using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoleBased1.Startup))]
namespace RoleBased1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
