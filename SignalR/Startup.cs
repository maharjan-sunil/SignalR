using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalR.Startup))]
namespace SignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
            //The assembly attribute adds the class to Owin's startup process, which executes the Configuration method when Owin starts up.
            //This in turn calls the MapSignalR method, which creates routes for all SignalR hubs in the application.
        }
    }
}
