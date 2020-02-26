using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS4200_CentricProject_Team12.Startup))]
namespace MIS4200_CentricProject_Team12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
