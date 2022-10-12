using Microsoft.Owin;
using Owin;
[assembly: OwinStartupAttribute(typeof(BanBif.Nuevo.Pandora.App.Startup))]

namespace BanBif.Nuevo.Pandora.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            //SignalR
            //app.MapSignalR();

            //HangFire
            //GlobalConfiguration.Configuration.UseSqlServerStorage("HangFireConnection");
            //app.UseHangfireDashboard("/NovusDashboardScheduler");

            //Test diferent culture here
            //var cultureInfo = new CultureInfo("es-MX");
            //CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            //CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }
    }
}