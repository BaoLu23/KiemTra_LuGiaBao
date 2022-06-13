using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KiemTra_LuGiaBao.Startup))]
namespace KiemTra_LuGiaBao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
