using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CuaHangOto.Startup))]
namespace CuaHangOto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
