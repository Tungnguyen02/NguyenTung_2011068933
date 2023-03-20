using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenTung_8933.Startup))]
namespace NguyenTung_8933
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
