using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllisonKieferMIS4200.Startup))]
namespace AllisonKieferMIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
