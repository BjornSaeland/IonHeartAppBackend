using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(IonHeartHealthService.Startup))]

namespace IonHeartHealthService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}