using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BanBif.Nuevo.Pandora.App.Seguridad
{
    [AttributeUsage(AttributeTargets.All)]
    public class AppAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            try
            {
                //If User is Authenticated then...
                if (httpContext.User.Identity.IsAuthenticated && !string.IsNullOrEmpty(UserSession.BearerToken)) return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //TODO:For Alvaro
            var routeData = filterContext.RequestContext.RouteData;
            //var moduleName = GetAreaName(routeData);
            //var controllerName = GetControllerName(routeData);
            //var actionName = GetActionName(routeData);

            base.HandleUnauthorizedRequest(filterContext);
            filterContext.Controller.TempData["UnauthorizedRequest"] = true;
            filterContext.Controller.TempData["Message"] = "No Autorizado";

            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index", area = "" }));
        }
    }
}