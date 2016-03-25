using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealTime_One.Startup))]
namespace RealTime_One
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
