using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;


namespace BanBif.Nuevo.Pandora.App
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit https://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Login/Index"),
                SlidingExpiration = true
            });
        }
    }
}