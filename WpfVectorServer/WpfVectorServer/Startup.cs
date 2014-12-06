using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WpfVectorServer.Startup))]

namespace WpfVectorServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
