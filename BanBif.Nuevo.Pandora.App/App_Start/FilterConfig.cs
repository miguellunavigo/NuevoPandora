using System.Web;
using System.Web.Mvc;

namespace BanBif.Nuevo.Pandora.App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
